using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BackupThatShit2
{
    public static class SettingsManager
    {
        public static SettingStructure currentSS;

        public static void checkSettingsFile()
        {
            string settingsDirectory = Directory.GetCurrentDirectory() + @"\settings.xml";
            SettingStructure ss;

            if (!File.Exists(settingsDirectory))
            {
                string tempDir = Directory.GetCurrentDirectory() + @"\Backups";
                if (!Directory.Exists(tempDir))
                    Directory.CreateDirectory(tempDir);

                ss = new SettingStructure("0", "1", tempDir, "0", "15");
                saveSettings(ss);
                currentSS = ss;
            }
            else
            {
                currentSS = loadSettings();
            }
        }

        /*private static void createNode(string ID, string Name, string pPrice, XmlTextWriter writer)
        {
            writer.WriteStartElement("id");
            writer.WriteString(ID);
            writer.WriteEndElement();
            writer.WriteStartElement("name");
            writer.WriteString(Name);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_price");
            writer.WriteString(pPrice);
            writer.WriteEndElement();
        }*/

        public static bool saveSettings(SettingStructure ss)
        {
            XmlTextWriter writer = new XmlTextWriter("settings.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;

            writer.WriteStartElement("Settings");
            
            //FOLDER SETTINGS
            writer.WriteStartElement("folder_backup_enabled");
            writer.WriteString(ss.foldersEnabled);
            writer.WriteEndElement();
            
            writer.WriteStartElement("target_folder");
            writer.WriteString(ss.targetFolder);
            writer.WriteEndElement();

            writer.WriteStartElement("folder_redundancy");
            writer.WriteString(ss.folderRedundancy);
            writer.WriteEndElement();

            //FTP SETTINGS

            //TIMER FOLDER SETTINGS
            writer.WriteStartElement("timer_folder_enabled");
            writer.WriteString(ss.folderTimerEnabled);
            writer.WriteEndElement();

            writer.WriteStartElement("timer_folder_interval");
            writer.WriteString(ss.folderTimerInterval);
            writer.WriteEndElement();

            //TIMER FTP SETTINGS


            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();

            return true;
        }

        public static SettingStructure loadSettings()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\settings.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);

            string foldersEnabled = readXmlNode(xmldoc.GetElementsByTagName("folder_backup_enabled"));
            string folderRedundancy = readXmlNode(xmldoc.GetElementsByTagName("folder_redundancy"));
            string targetFolder = readXmlNode(xmldoc.GetElementsByTagName("target_folder"));
            string folderTimerEnabled = readXmlNode(xmldoc.GetElementsByTagName("timer_folder_enabled"));
            string folderTimerInterval = readXmlNode(xmldoc.GetElementsByTagName("timer_folder_interval"));

            SettingStructure ss = new SettingStructure(foldersEnabled, folderRedundancy, targetFolder, folderTimerEnabled, folderTimerInterval);
            fs.Close();
            return ss;
        }

        private static string readXmlNode(XmlNodeList xmlnode)
        {
            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                return xmlnode[i].InnerText;
            }
            return null;
        }
    }
}
