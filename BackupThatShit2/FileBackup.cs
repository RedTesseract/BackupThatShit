using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BackupThatShit2
{
    public static class FileBackup
    {
        public static void BackupThatShit(string filePath)
        {
            //Debug.WriteLine("BTS CALLED: " + filePath);
            FileAttributes attr = File.GetAttributes(filePath);
            SettingStructure ss = SettingsManager.loadSettings();
            //Debug.WriteLine("Settings: " + SettingsManager.currentSS.foldersEnabled);
            DateTime currentTime = DateTime.Now;

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                //MessageBox.Show(ss.targetFolder + @"\" + new DirectoryInfo(filePath).Name + " " + currentTime.ToString("dd-MM-yyyy HH-MM-ss"));
                CopyDirectory(filePath, ss.targetFolder + @"\" + new DirectoryInfo(filePath).Name + " " + currentTime.ToString("dd-MM-yyyy HH-MM-ss"));
            }
            else
            {
                string tempDir = ss.targetFolder + @"\" + Path.GetFileNameWithoutExtension(filePath) + " " + currentTime.ToString("dd-MM-yyyy HH-MM-ss");
                //MessageBox.Show(tempDir);
                Directory.CreateDirectory(tempDir);
                File.Copy(filePath, tempDir + @"\" + Path.GetFileName(filePath));
            }
        }

        private static void CopyDirectory(string sourcePath, string destPath)
        {
            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
            }

            foreach (string file in Directory.GetFiles(sourcePath))
            {
                string dest = Path.Combine(destPath, Path.GetFileName(file));
                File.Copy(file, dest);
            }

            foreach (string folder in Directory.GetDirectories(sourcePath))
            {
                string dest = Path.Combine(destPath, Path.GetFileName(folder));
                CopyDirectory(folder, dest);
            }
        }
    }
}
