using System;
using System.Collections.Specialized;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace Configuration
{
    public class ConfigurationSettings
    {
        public static NameValueCollection AppSettings;

        public static void LoadConfig()
        {
            try
            {
                string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                string ConfigFile = Path.Combine(AppPath, "App.config");

                if (File.Exists(ConfigFile) == false)
                {
                    System.Windows.Forms.MessageBox.Show("Config file does not exist");
                    Application.Exit();
                    return;
                }

                XmlDocument oXml = new XmlDocument();

                oXml.Load(ConfigFile);

                XmlNodeList oList = oXml.GetElementsByTagName("appSettings");

                AppSettings = new NameValueCollection();

                foreach (XmlNode oNode in oList)
                {
                    foreach (XmlNode oKey in oNode.ChildNodes)
                    {
                        AppSettings.Add(oKey.Attributes["key"].Value, oKey.Attributes["value"].Value);
                    }
                }
            }
            catch (Exception) { throw; }
        }

    }
}