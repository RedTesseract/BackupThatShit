using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BackupThatShit2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                FileBackup.BackupThatShit(args[0]);
            }
            else
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
                string menuCommand = string.Format("\"{0}\" \"%L\"",
                                   Application.ExecutablePath);
                RegistryManager.Register("*", "BTSRT", "Backup That Shit", menuCommand);
                RegistryManager.Register("Directory", "BTSRT", "Backup That Shit", menuCommand);


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                foreach (string s in args)
                {
                    Debug.WriteLine("arg: " + s);
                }

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

        static void OnProcessExit(object sender, EventArgs e)
        {
            RegistryManager.Unregister("*", "BTSRT");
            RegistryManager.Unregister("Directory", "BTSRT");
        }
    }
}
