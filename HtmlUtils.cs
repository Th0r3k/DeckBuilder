using System;
using System.Net;
using System.IO;
using MTGDeckBuilder.Utils;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace MTGDeckBuilder.Utils
{
  class HtmlUtils
  {
    public static string CleanInnerText(string _sText)
    {
      string sFormatted = _sText;
      sFormatted = Regex.Replace(sFormatted, @"\r\n?|\n", " ");
      const string reduceMultiSpace = @"[ ]{2,}";
      sFormatted = Regex.Replace(sFormatted.Replace("\t", " "), reduceMultiSpace, "");
      return sFormatted;
    }
    public static HtmlAgilityPack.HtmlDocument GetHTML(string _sURL)
    {
      var web = new HtmlAgilityPack.HtmlWeb();
      web.PreRequest += (request) => { request.Headers.Add("Accept-Language", "es-ES"); return true; };
      HtmlAgilityPack.HtmlDocument doc = null;
      bool bTryLoad = true;
      while (bTryLoad)
      {
        bTryLoad = false;
        try
        {
          doc = web.Load(_sURL);
        }
        catch (System.Exception e)
        {
          Console.Write("Error URL Request[URL: " + _sURL + "][Error: " + e.ToString() + "]\n");
          bTryLoad = true;
        }
      }
      return doc;
    }
    public static byte[] LoadImageFromURL(string _sURL)
    {
      bool bTryLoad = true;
      byte[] data = null;
      while (bTryLoad)
      {
        bTryLoad = false;
        try
        {
          HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_sURL);
          using (WebResponse response = request.GetResponse())
          {
            using (Stream stream = response.GetResponseStream())
            {
              using (MemoryStream ms = new MemoryStream())
              {
                int count = 0;
                do
                {
                  byte[] buf = new byte[1024];
                  count = stream.Read(buf, 0, 1024);
                  ms.Write(buf, 0, count);
                } while (stream.CanRead && count > 0);
                data = ms.ToArray();
              }
            }
          }
        }
        catch (System.Exception e)
        {
          Console.Write("Error loading image[URL: " + _sURL + "][Error: " + e.ToString() + "]\n");
          bTryLoad = true;
        }
      }
      return data;
    }
  }
}
