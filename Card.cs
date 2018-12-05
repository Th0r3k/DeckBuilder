using System;
using System.Collections.Generic;
using System.Xml;
using System.Net;
using System.IO;
using MTGDeckBuilder.Utils;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
namespace MTGDeckBuilder.DataBase
{
  public class Card
  {
    public static int iVersionMayor = 1;
    public static int iVersionMinor = 0;
    public static string sProxyExtension = ".png";
    public static string sIconExtension = ".png";
    public static string sCardExtension = ".card";
    public static string sTheGathererURL = "http://gatherer.wizards.com/";

    public  Int64  iUniqueID      = -1;
    public  string sCardImportURL = "";
    private string sCardProxyPath = "";
    public  string sCardProxyURL = "";
    public  string sCardXMLPath = "";
    public  string sCardName = "";
    public  string sCardOriginalName = "";
    public  List<string> sManaCost = new List<string>();
    public  int iCMC = -1;
    public  string sType = "";
    public  List<string> sText = new List<string>();
    public  int iPower = -1;
    public  int iToughness = -1;
    public  string sSet = "extra";
    public  string sSetIcon = "";
    public  string eRarity = "";
    public  int iSetNumber = -1;
    public  string sArtist = "";
    public  byte[] oImage;

    public static string GetCardFile(string cardOriginalName, string set)
    {
      return "data/cards/" + FileUtils.CleanName(set) + "/cards/" + FileUtils.CleanName(cardOriginalName) + "/" + FileUtils.CleanName(cardOriginalName) + sCardExtension;
    }
    override public string ToString() 
    {
      return sCardName;
    }
    private static string GetID(string line)
    {
      int iFirst = line.IndexOf("'") + 1;
      int iLast = line.LastIndexOf("'");
      return line.Substring(iFirst, iLast - iFirst);
    }
    public static string CleanInnerText(string _sText)
    {
      string sFormatted = _sText;
      sFormatted = Regex.Replace(sFormatted, @"\r\n?|\n", " ");
      const string reduceMultiSpace = @"[ ]{2,}";
      sFormatted = Regex.Replace(sFormatted.Replace("\t", " "), reduceMultiSpace, "");
      return sFormatted;
    }
    public static string GetTheGathererImageURL(string sRelativeURL)
    {
      return sTheGathererURL + sRelativeURL.Replace("../", "").Replace("amp;", "");
    }
    
    private static HtmlNode GetValueNode(HtmlNode node)
    {
      if (node == null) return null;
      return node.SelectSingleNode(".//div[@class='value']");
    }
    private static string GetInnerValue(HtmlNode node)
    {
      if (node == null) return "";
      HtmlNode value = node.SelectSingleNode(".//div[@class='value']");
      if (value == null) return "";
      return CleanInnerText(value.InnerText);
    }
    
    private static HtmlNode GetRow(HtmlNode node, string row)
    {
      return node.SelectSingleNode("//div[@id='" + row + "']");
    }
    public Card(string sOriginalName, string sSetName)
    { 
      sCardOriginalName = sOriginalName;
      sSet = sSetName;
    }
    public Card(Card _rhs)
    {
      iUniqueID = _rhs.iUniqueID;
      sCardImportURL = String.Copy(_rhs.sCardImportURL);
      sCardProxyPath = String.Copy(_rhs.sCardProxyPath);
      sCardProxyURL = String.Copy(_rhs.sCardProxyURL);
      sCardXMLPath = String.Copy(_rhs.sCardXMLPath);
      sCardName = String.Copy(_rhs.sCardName);
      sCardOriginalName = String.Copy(_rhs.sCardOriginalName);
      sManaCost = new List<string>();
      foreach (string sMana in _rhs.sManaCost)
        sManaCost.Add(String.Copy(sMana));
      iCMC = _rhs.iCMC;
      sType = String.Copy(_rhs.sType);
      sText = new List<string>();
      foreach (string sLine in _rhs.sText)
        sText.Add(String.Copy(sLine));
      iPower = _rhs.iPower;
      iToughness = _rhs.iToughness;
      sSet = String.Copy(_rhs.sSet);
      sSetIcon = String.Copy(_rhs.sSetIcon);
      eRarity = String.Copy(_rhs.eRarity);
      iSetNumber = _rhs.iSetNumber;
      sArtist = String.Copy(_rhs.sArtist);
      if (_rhs.oImage != null)
        _rhs.oImage.CopyTo(oImage, 0);
    }
    private string GetCardFile()
    {
      string sSetDir = FileUtils.CleanName(sSet);
      string sCardFile = FileUtils.CleanName(sCardOriginalName);
      return "data/cards/" + sSetDir + "/cards/" + iSetNumber.ToString("000") + "-"+ sCardFile + "/" + sCardFile + sCardExtension;
    }
    private string GetProxyFile()
    {
      string sSetDir = FileUtils.CleanName(sSet);
      string sCardFile = FileUtils.CleanName(sCardOriginalName);
      return "data/cards/" + sSetDir + "/cards/" + iSetNumber.ToString("000") + "-" + sCardFile + "/" + sCardFile + sProxyExtension;
    }

    public void ImportFromTheGatherer(string sUrl)
    {
      sCardImportURL = sUrl;
      if (System.IO.File.Exists(GetCardFile()))
      { 
        ImportFromCard(XmlUtils.LoadXMLFile(GetCardFile()));
        return;
      }
      var doc = HtmlUtils.GetHTML(sUrl).DocumentNode;
      var scripts = doc.SelectNodes("//script[@type='text/javascript']");
      string nameRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_ctl02_nameRow";
      string manaRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_manaRow";
      string cmcRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cmcRow";
      string typeRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_typeRow";
      string textRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_textRow";
      string ptRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_ptRow";
      string setRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_setRow";
      string rarityRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_rarityRow";
      string numberRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_numberRow";
      string artistRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_artistRow";
      string imageRow = "ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_ctl02_cardImage";
      // Update row IDs
      foreach (var script in scripts)
      {
        if (script.InnerText.Contains("ClientIDs"))
        {
          foreach (var line in script.InnerText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
          {
            if(line.Contains("ClientIDs.nameRow"))          nameRow = GetID(line);
            else if (line.Contains("ClientIDs.manaRow"))    manaRow = GetID(line);
            else if (line.Contains("ClientIDs.cmcRow"))     cmcRow = GetID(line);
            else if (line.Contains("ClientIDs.typeRow"))    typeRow = GetID(line);
            else if (line.Contains("ClientIDs.textRow"))    textRow = GetID(line);
            else if (line.Contains("ClientIDs.ptRow"))      ptRow = GetID(line);
            else if (line.Contains("ClientIDs.setRow"))     setRow = GetID(line);
            else if (line.Contains("ClientIDs.rarityRow"))  rarityRow = GetID(line);
            else if (line.Contains("ClientIDs.numberRow"))  numberRow = GetID(line);
            else if (line.Contains("ClientIDs.artistRow"))  artistRow = GetID(line);
            else if (line.Contains("ClientIDs.cardImage"))  imageRow = GetID(line);
          }
          break;
        }
      }
      // Get Name
      sCardName = sType = GetInnerValue(GetRow(doc, nameRow)).Replace("/", "-").Replace("\\", "-");
      // Get Set
      var setNode = GetRow(doc, setRow);
      if (setNode != null)
      {
        var textNodes = GetValueNode(setNode).SelectNodes(".//a");
        foreach (var node in textNodes)
        {
          var expImg = node.SelectSingleNode(".//img");
          if (expImg != null)
          {
            sSetIcon = expImg.Attributes["alt"].Value;
            SaveIcon(sSetIcon, GetTheGathererImageURL(expImg.Attributes["src"].Value));
          }
          else
          {
            sSet = CleanInnerText(node.InnerText);
          }
        }
      }
      // Get Mana Cost
      var manaNode = GetRow(doc, manaRow);
      if (manaNode != null)
      {
        foreach (var node in GetValueNode(manaNode).SelectNodes(".//img"))
        {
          string manaType = node.Attributes["alt"].Value;
          sManaCost.Add(manaType);
          SaveIcon(manaType, GetTheGathererImageURL(node.Attributes["src"].Value));
        }
      }
      // Get Converted Mana Cost
      int.TryParse(GetInnerValue(GetRow(doc, cmcRow)), out iCMC);
      // Get Type
      sType = GetInnerValue(GetRow(doc, typeRow));
      // Get Text
      var textNode = GetRow(doc, textRow);
      if (textNode != null)
      {
        foreach (var node in GetValueNode(textNode).SelectNodes(".//div[@class='cardtextbox']"))
        {
          sText.Add(node.InnerText);
        }
      }
      // Get Power/Resistance
      var ptNode = GetRow(doc, ptRow);
      if (ptNode != null)
      {
        string[] iValues = GetInnerValue(ptNode).Split('/');
        for(int i = 0; i < iValues.Length; ++i)
        { 
          if(i == 0) int.TryParse(iValues[0], out iPower);
          if(i == 1) int.TryParse(iValues[1], out iToughness);
        }
      }
      // Get Rarity
      eRarity = GetInnerValue(GetRow(doc, rarityRow));
      // Get Setnumber
      int.TryParse(GetInnerValue(GetRow(doc, numberRow)), out iSetNumber);
      // Get Artist
      sArtist = GetInnerValue(GetRow(doc, artistRow));
      // Get Proxy
      var proxyNode = doc.SelectSingleNode("//img[@id='" + imageRow + "']");
      sCardProxyURL = GetTheGathererImageURL(proxyNode.Attributes["src"].Value);
    }

    public string GetImagePath()
    {
      if(!System.IO.File.Exists(sCardProxyPath))
      { 
        oImage = HtmlUtils.LoadImageFromURL(sCardProxyURL);
        SaveProxy();
      }
      return sCardProxyPath;
    }

   

    public void SaveIcon(string name, string url)
    {
      Icon oNewIcon = new Icon(name);
      oNewIcon.ImportFromURL(url);
      oNewIcon.Export();
    }
    private void SaveProxy()
    {
      sCardProxyPath = GetProxyFile();
      FileUtils.SaveImage(oImage, sCardProxyPath);
      SaveCRD();
    }
    public void ImportFromCard(XmlDocument _Xml)
    {
      sCardOriginalName = _Xml.SelectSingleNode("//card").Attributes["id"].Value;
      sCardImportURL = _Xml.SelectSingleNode("//card").Attributes["url"].Value;
      sCardName = _Xml.SelectSingleNode("//name").Attributes["value"].Value;
      sCardProxyPath = _Xml.SelectSingleNode("//proxy").Attributes["path"].Value;
      sCardProxyURL = _Xml.SelectSingleNode("//proxy").Attributes["url"].Value;
      sCardXMLPath = _Xml.SelectSingleNode("//xml").Attributes["path"].Value;
      XmlNode manaNode = _Xml.SelectSingleNode("//mana");
      foreach (XmlNode mana in manaNode.ChildNodes)
        sManaCost.Add(mana.Attributes["value"].Value);
      int.TryParse(_Xml.SelectSingleNode("//crc").Attributes["value"].Value, out iCMC);
      sType = _Xml.SelectSingleNode("//type").Attributes["value"].Value;
      XmlNode textNode = _Xml.SelectSingleNode("//text");
      foreach (XmlNode line in textNode.ChildNodes)
        sText.Add(line.Attributes["value"].Value);
      int.TryParse(_Xml.SelectSingleNode("//pt").Attributes["p"].Value, out iPower);
      int.TryParse(_Xml.SelectSingleNode("//pt").Attributes["t"].Value, out iToughness);
      sSet = _Xml.SelectSingleNode("//set").Attributes["value"].Value;
      sSetIcon = _Xml.SelectSingleNode("//set").Attributes["icon"].Value;
      eRarity = _Xml.SelectSingleNode("//rarity").Attributes["value"].Value;
      int.TryParse(_Xml.SelectSingleNode("//number").Attributes["value"].Value, out iSetNumber);
      sArtist = _Xml.SelectSingleNode("//artist").Attributes["value"].Value;

    }
    private void SaveCRD()
    {
      sCardXMLPath = GetCardFile();
      var xmldoc = new XmlDocument();
      XmlNode oRootNode = XmlUtils.CreateNode(xmldoc, "card", 
                                              "id", sCardOriginalName, 
                                              "url", sCardImportURL,
                                              "version", iVersionMayor.ToString() + "." + iVersionMinor.ToString());
      XmlUtils.CreateNode(oRootNode, "name", "value", sCardName);
      XmlUtils.CreateNode(oRootNode, "proxy", "path", sCardProxyPath, "url", sCardProxyURL);
      XmlUtils.CreateNode(oRootNode, "xml", "path", sCardXMLPath);
      XmlNode oManaNode = XmlUtils.CreateNode(oRootNode, "mana");
      foreach (var sMana in sManaCost)
        XmlUtils.CreateNode(oManaNode, "manaCount", "value", sMana);
      XmlUtils.CreateNode(oRootNode, "crc", "value", iCMC.ToString());
      XmlUtils.CreateNode(oRootNode, "type", "value", sType);
      XmlNode text = XmlUtils.CreateNode(oRootNode, "text");
      foreach (var line in sText)
        XmlUtils.CreateNode(text, "line", "value", line);
      XmlUtils.CreateNode(oRootNode, "pt", "p", iPower.ToString(), "t", iToughness.ToString());
      XmlUtils.CreateNode(oRootNode, "set", "value", sSet, "icon", sSetIcon);
      XmlUtils.CreateNode(oRootNode, "rarity", "value", eRarity);
      XmlUtils.CreateNode(oRootNode, "number", "value", iSetNumber.ToString());
      XmlUtils.CreateNode(oRootNode, "artist", "value", sArtist);
      FileUtils.CreateSubDirectories(sCardXMLPath);
      xmldoc.Save(sCardXMLPath);
    }

    public void Export()
    {
      //SaveProxy();
      SaveCRD();
    }
  }
}
