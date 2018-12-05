using System;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using MTGDeckBuilder.Utils;
using System.Threading.Tasks;
namespace MTGDeckBuilder.DataBase
{
  class Database
  {
    public static int iVersionMayor = 1;
    public static int iVersionMinor = 0;
    private static string sTheGathereURL = "http://gatherer.wizards.com/Pages/Default.aspx";
    public List<Set> m_Sets = new List<Set>();
   
    public void UpdateDatabaseFromTheGatherer()
    {
      // Get all search-able sets
      var baseDoc = HtmlUtils.GetHTML(sTheGathereURL);
      string sSetsMenuID = "ctl00_ctl00_MainContent_Content_SearchControls_setAddText";
      var scripts = baseDoc.DocumentNode.SelectNodes("//script[@type='text/javascript']");
      // Extract menu identifier (safety)
      foreach (var script in scripts)
      {
        if (script.InnerText.Contains("ClientIDs"))
        {
          foreach (var line in script.InnerText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
          {
            if (line.Contains("ClientIDs.setAddText"))
            {
              int iFirst = line.IndexOf("'") + 1;
              int iLast = line.LastIndexOf("'");
              sSetsMenuID = line.Substring(iFirst, iLast - iFirst);
            }
          }
        }
      }
        // Get combobox options
      var menuCombobox = baseDoc.DocumentNode.SelectSingleNode("//select[@id='" + sSetsMenuID + "']");
      if (menuCombobox != null)
      {
        var lstSets = menuCombobox.SelectNodes(".//option");

        foreach (var sSetID in lstSets)
        {
          if (sSetID.Attributes["value"].Value.Length == 0)
            continue;
          m_Sets.Add(new Set(sSetID.Attributes["value"].Value));
        }
      }
      int i = 0;
      foreach(var set in m_Sets)
      {
        ++i;
        Console.WriteLine("Importing Set["+i.ToString() + "/"+ m_Sets.Count.ToString() +"]: " + set.sSetName);
        set.ImportFromTheGatherer();
        set.Export();
      }
      Export();
    }

    public void Load(TreeNodeCollection tree)
    {
      string sCardsPath = System.IO.Directory.GetCurrentDirectory() + "\\data\\cards\\";
      var dirs = Directory.GetDirectories(sCardsPath);
      foreach (var dir in dirs)
      {
        Set oSet = new Set(dir);
        oSet.Load(dir, tree);
        m_Sets.Add(oSet);
      }
    }
    public void Export()
    {
      XmlDocument doc = new XmlDocument();
      XmlNode root = XmlUtils.CreateNode(doc, "database", "id", "TheGatherer", "version", iVersionMayor.ToString() + "." + iVersionMinor.ToString());
      XmlNode sets = XmlUtils.CreateNode(root, "sets");
      foreach (Set set in m_Sets)
      {
        XmlUtils.CreateNode(sets, "set", 
                                  "id", set.sSetName, 
                                  "path", set.sSetFile);
      }
      doc.Save("data/database.base");
    }
  }
}
