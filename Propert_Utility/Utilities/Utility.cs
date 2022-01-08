using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Propert_Utility.Utilities
{
   public static class Utility
    {
        public static string GetFilePath(XDocument xml)
        {
            try
            {
                foreach (var FolderPath in xml.Descendants("FolderPath"))
                {
                    //second loop for child 
                    foreach (var path in FolderPath.Descendants("path"))
                    {
                        //getting values from node
                        var name = path.Value.Trim();// .Element("name").Value.ToString();
                        if (name.Length > 0)
                        {
                            if (CheckFilePath(name))
                            {
                                return name;
                            }
                            else
                            {
                                return "";
                            }
                        }
                        //matching user name with xml users 
                       

                    }
                }
                    return "";
            }
            catch(Exception ex)
            {
                return "";
            }
        }

        public static bool SetFilePath(string newpath,string xmlpath)
        {
            try
            {

                var doc = XElement.Load(xmlpath);
                XElement upd = (from games in doc.Descendants("FolderPath")
                                
                                select games).Single();

                // saveGame.Element("balance").Value = "50";

                //   doc.Save(xmlpath);

                upd.Element("path").Value = newpath;
                doc.Save(xmlpath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool CheckFilePath(string xmlpath)
        {
            try
            {
                bool flag = Directory.Exists(xmlpath);
                return flag;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
