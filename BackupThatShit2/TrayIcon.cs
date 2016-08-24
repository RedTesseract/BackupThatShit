using BackupThatShit2.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupThatShit2
{
    class TrayIcon : System.IDisposable
    {
        NotifyIcon ni;

        public TrayIcon()
        {
            ni = new NotifyIcon();
        }

        public void Display(){
            //ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            ni.Icon = Resources.BackupIcon;
			ni.Text = "System Tray Utility Application Demonstration Program";
			ni.Visible = true;

			ni.ContextMenuStrip = new ContextMenus().Create();
        }

        public void Dispose()
        {
            ni.Dispose();
        }

        /*void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Process.Start(SettingsManager.currentSS.targetFolder, null);
            }
        }*/
    }
}
