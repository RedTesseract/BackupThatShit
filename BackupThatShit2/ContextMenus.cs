using BackupThatShit2.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BackupThatShit2
{
    class ContextMenus
    {

        bool isSettingsLoaded = false;

        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Windows Explorer.
            item = new ToolStripMenuItem();
            item.Text = "Open Backup Folder";
            item.Click += new EventHandler(Explorer_Click);
            //item.Image = Resources.Explorer;
            menu.Items.Add(item);

            // Settings.
            item = new ToolStripMenuItem();
            item.Text = "Settings";
            item.Click += new EventHandler(Settings_Click);
            //item.Image = Resources.BackupIcon;
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler(Exit_Click);
            //item.Image = Resources.Exit;
            menu.Items.Add(item);

            return menu;
        }

        void Explorer_Click(object sender, EventArgs e)
        {
            string menuCommand = string.Format("\"{0}\" \"%L\"",
                                   Application.ExecutablePath);
            Debug.WriteLine("CLICKED: " + menuCommand);
            Register("Directory", "BTSRT", "Backup That Shit", menuCommand);

            //Unregister("jpegfile", "Simple Context Menu");
            //Process.Start(SettingsManager.currentSS.targetFolder, null);
        }

        public void Register(string fileType,
           string shellKeyName, string menuText, string menuCommand)
        {
            // create path to registry location
            string regPath = string.Format(@"{0}\shell\{1}",
                                           fileType, shellKeyName);

            // add context menu to the registry
            using (RegistryKey key =
                   Registry.ClassesRoot.CreateSubKey(regPath))
            {
                key.SetValue(null, menuText);
            }

            // add command that is invoked to the registry
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(
                string.Format(@"{0}\command", regPath)))
            {
                key.SetValue(null, menuCommand);
            }
        }

        public void Unregister(string fileType, string shellKeyName)
        {
            Debug.Assert(!string.IsNullOrEmpty(fileType) &&
                !string.IsNullOrEmpty(shellKeyName));

            // path to the registry location
            string regPath = string.Format(@"{0}\shell\{1}",
                                           fileType, shellKeyName);

            // remove context menu from the registry
            Registry.ClassesRoot.DeleteSubKeyTree(regPath);
        }

        void Settings_Click(object sender, EventArgs e)
        {
            if (!isSettingsLoaded)
            {
                isSettingsLoaded = true;
                new frmSettings().ShowDialog();
                isSettingsLoaded = false;
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
