using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTGDeckBuilder.Utils;
using System.Xml;
namespace MTGDeckBuilder.DataBase
{
  class Icon
  {
    public static int iVersionMayor = 1;
    public static int iVersionMinor = 0;
    public static string sIconsPath = "data/icons/";
    public static string sIconsImageExt = ".png";
    public static string sIconsFileExt = ".icn";
    public string m_sName       = "";
    public string m_sImagePath  = "";
    public string m_sXmlPath    = "";
    public byte[] m_oImage      = null;
    public string m_sURL        = "";

    public Icon(string name)
    {
      m_sName = name;
    }
    private string GetIconFile()
    {
      string sPath = "data/icons/" + FileUtils.CleanName(m_sName) + "/" + FileUtils.CleanName(m_sName) + sIconsFileExt;
      return sPath;
    }
    private string GetIconImageFile()
    {
      string sPath = "data/icons/" + FileUtils.CleanName(m_sName) + "/" + FileUtils.CleanName(m_sName) + sIconsFileExt;
      return sPath;
    }
    public void ImportFromURL(string sUrl)
    {
      m_sURL = sUrl;
    }
    public void ImportFromFile(string sPath)
    {

    }
    public void ExportImage()
    {
      string sPath = GetIconImageFile();
      if (!System.IO.File.Exists(sPath))
        FileUtils.SaveImage(HtmlUtils.LoadImageFromURL(m_sURL), sPath);
    }
    public void Export()
    {
      m_sXmlPath = GetIconFile();
      if (System.IO.File.Exists(m_sXmlPath))
        return;
      var xmldoc = new XmlDocument();
      XmlNode oRootNode = XmlUtils.CreateNode(xmldoc, "icon",
                                              "id", m_sName,
                                              "version", iVersionMayor.ToString() + "." + iVersionMinor.ToString());
      XmlUtils.CreateNode(oRootNode, "image", "path", m_sImagePath, "url", m_sURL);
      FileUtils.CreateSubDirectories(m_sXmlPath);
      xmldoc.Save(m_sXmlPath);
    }
  }
}
