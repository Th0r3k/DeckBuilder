using System.Xml;

namespace MTGDeckBuilder.Utils
{
  class XmlUtils
  {
    public static XmlDocument LoadXMLFile(string sPath)
    {
      XmlDocument doc = new XmlDocument();
      using (System.IO.FileStream fStream = System.IO.File.Open(sPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
      {
        if (fStream.Length == 0)
        {
          System.Console.WriteLine("Error Opening file: " + sPath);
          return null;
        }
        doc.Load(fStream);
      }
      return doc;
    }
    public static XmlNode CreateNode(XmlDocument _oDoc, string _sNodeName, params string[] _aAttributesValues)
    {
      XmlNode oNewNode = _oDoc.CreateElement(_sNodeName);
      for (int i = 0; i < _aAttributesValues.Length; i += 2)
      {
        string sAttr = _aAttributesValues[i + 0];
        string sValue = i + 1 < _aAttributesValues.Length ? _aAttributesValues[i + 1] : "";

        XmlAttribute oAttr = _oDoc.CreateAttribute(sAttr);
        oAttr.Value = sValue;
        oNewNode.Attributes.Append(oAttr);
      }

      if (_oDoc.FirstChild == null)
        _oDoc.AppendChild(oNewNode);
      return oNewNode;
    }

    public static XmlNode CreateNode(XmlNode _nParent, string _sNodeName, params string[] _aAttributesValues)
    {
      XmlDocument oOwner = _nParent is XmlDocument ? _nParent as XmlDocument : _nParent.OwnerDocument;
      XmlNode oNode = CreateNode(oOwner, _sNodeName, _aAttributesValues);
      _nParent.AppendChild(oNode);
      return oNode;
    }
  }
}
