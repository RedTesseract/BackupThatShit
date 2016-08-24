using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupThatShit2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (TrayIcon ti = new TrayIcon())
            {
                ti.Display();

                SettingsManager.checkSettingsFile();
                //http://www.codeproject.com/Articles/15171/Simple-shell-context-menu

                Thread thread = new Thread(new ThreadStart(TimerThread.TimerFunction));
                thread.Start();

                Application.Run();
            }
        }
    }
}
