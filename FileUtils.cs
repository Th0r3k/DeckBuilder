using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace MTGDeckBuilder.Utils
{
  class FileUtils
  {
    public static string CleanName(string path)
    {
      string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
      Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
      return r.Replace(path, "");
    }
    public static void CreateSubDirectories(string path)
    {
      try
      {
        string dir = System.IO.Path.GetDirectoryName(path);
        if (!System.IO.Directory.Exists(dir))
          System.IO.Directory.CreateDirectory(dir);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    }
    public static void SaveImage(byte[] oContent, string sPath)
    {
      try
      {
        FileUtils.CreateSubDirectories(sPath);
        using (FileStream fs = new FileStream(sPath, FileMode.Create))
        {
          using (BinaryWriter bw = new BinaryWriter(fs))
          {
            bw.Write(oContent);
          }
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    }
  }
}
