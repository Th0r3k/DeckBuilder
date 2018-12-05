using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTGDeckBuilder.Utils;
using System.Xml;
using System.Windows.Forms;
namespace MTGDeckBuilder.DataBase
{
  class Set
  {
    public static int iVersionMayor = 1;
    public static int iVersionMinor = 0;
    // the gatherer
    private static string sCardPage = "http://gatherer.wizards.com/Pages/Card/Details.aspx?printed=true&";
    private static string sSearchPage = "http://gatherer.wizards.com/Pages/Search/Default.aspx?page=";
    private static string sShortType = "&sort=cn+";
    private static string sOutputType = "&output=checklist";
    private static string sSetExtension = ".set";

    public List<Card> m_lstCards = new List<Card>();
    public string sSetName = "";
    public string sSetFile = "";
    public Set(string sName)
    {
      sSetName = sName;
    }

    public Set(Set _rhs)
    {
      m_lstCards = new List<Card>();
      foreach (Card card in _rhs.m_lstCards)
        m_lstCards.Add(new Card(card));
      sSetName = String.Copy(_rhs.sSetName);
      sSetFile = String.Copy(_rhs.sSetFile);
    }

    private struct CardRequest
    {
      public CardRequest(string sName, string sUrl) { m_sCardName = sName; m_sUrl = sUrl; }
      public string m_sCardName;
      public string m_sUrl;
    }
    public void ImportFromTheGatherer()
    {
      List<CardRequest> lstRequest = new List<CardRequest>();
      uint iPage = 0;
      int iMaxCardNumber = 0;
      bool bFinished = false;
      string sSetSearch = "&set=[\"" + sSetName.Replace(" ", "+") + "\"]";
      while (!bFinished)
      {
        // Generate Search link
        string sSetSearchURL = sSearchPage + iPage.ToString() + sShortType + sOutputType + sSetSearch;
        var oPageSet = HtmlUtils.GetHTML(sSetSearchURL);
        var lstCards = oPageSet.DocumentNode.SelectNodes("//tr[@class='cardItem']");
        if (lstCards == null)
          break;
        foreach (var card in lstCards)
        {
          var numberNode = card.SelectSingleNode(".//td[@class='number']");
          int iCardNumber = int.Parse(numberNode.InnerHtml);
          if (iCardNumber > iMaxCardNumber) { iMaxCardNumber = iCardNumber; } else { bFinished = true; break; }
          var linkNode = card.SelectSingleNode(".//a[@class='nameLink']");
          string sCardName = HtmlUtils.CleanInnerText(linkNode.InnerText);
          string sUrl = sCardPage + linkNode.Attributes["href"].Value.Replace("../Card/Details.aspx?", "");
          lstRequest.Add(new CardRequest(sCardName, sUrl));
        }
        ++iPage;
      }
      int i = 0;
      foreach (var oRequest in lstRequest)
      {
        ++i;
        Card oNewCard = new Card(oRequest.m_sCardName, sSetName);
        Console.WriteLine("Importing Card[" + i.ToString() + "/" + lstRequest.Count + "]:" + oRequest.m_sCardName);
        oNewCard.ImportFromTheGatherer(oRequest.m_sUrl);
        m_lstCards.Add(oNewCard);
      }
    }

    public void Load(string sPath, System.Windows.Forms.TreeNodeCollection tree)
    {
      string sSetFile = sPath + "\\" + System.IO.Path.GetFileName(sPath) + sSetExtension;
      if (System.IO.File.Exists(sSetFile))
      {
        XmlDocument doc = XmlUtils.LoadXMLFile(sSetFile);
        XmlNode root = doc.SelectSingleNode("//set");
        sSetName = root.Attributes["id"].Value;
        TreeNode setNode = null;
        if (tree != null)
        {
          setNode = tree.Add(sSetName);
          setNode.Tag = this;
        }
           
        XmlNodeList cards = doc.SelectNodes("//card");
        if (cards.Count == 0)
          setNode.ForeColor = System.Drawing.Color.Red;
        foreach (XmlNode card in cards)
        {
          string sCardName = card.Attributes["name"].Value;
          string sCardFile = card.Attributes["path"].Value;
          Card oNewCard = new Card(sCardName, sSetName);
          oNewCard.ImportFromCard(XmlUtils.LoadXMLFile(sCardFile));
          if (setNode != null)
          { 
            TreeNode cardNode = setNode.Nodes.Add(oNewCard.sCardName);
            cardNode.Tag = oNewCard;
          }
          m_lstCards.Add(oNewCard);
        }
      }
      Console.WriteLine(sSetName);
    }
    public void Export()
    {
      foreach (Card card in m_lstCards)
      {
        card.Export();
      }
      if (!System.IO.Directory.Exists("data")) System.IO.Directory.CreateDirectory("data");
      if (!System.IO.Directory.Exists("data/cards/")) System.IO.Directory.CreateDirectory("data/cards/");
      string sSetCleanName = FileUtils.CleanName(sSetName);
      string sDir = "data/cards/" + sSetCleanName + "/";
      if (!System.IO.Directory.Exists(sDir)) System.IO.Directory.CreateDirectory(sDir);
      var xmldoc = new XmlDocument();
      XmlNode oRootNode = XmlUtils.CreateNode(xmldoc, "set", "id", sSetName,
                                              "version", iVersionMayor.ToString() + "." + iVersionMinor.ToString());
      XmlNode oCards = XmlUtils.CreateNode(oRootNode, "cards");
      foreach (Card card in m_lstCards)
      {
        XmlUtils.CreateNode(oCards, "card", "name", card.sCardOriginalName, "path", card.sCardXMLPath);
      }
      sSetFile = sDir + sSetCleanName + sSetExtension;
      xmldoc.Save(sSetFile);
    }
  }
}
