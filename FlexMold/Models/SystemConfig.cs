using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexMold.Models
{
   public static class SystemConfig
    {
        public readonly static string XmlFilePath = "";
        static SystemConfig()
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + ConfigurationManager.AppSettings["ConfigXml"].ToString();
            XmlFilePath = path;
        }
       
    }
}
