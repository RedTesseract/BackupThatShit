using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BackupThatShit2
{
    public partial class frmSettings : Form
    {
        string chosenDirectory;

        public frmSettings()
        {
            InitializeComponent();

            SettingStructure ss = SettingsManager.currentSS;

            if (ss.foldersEnabled.Equals("0"))
            {
                gbTarget.Enabled = false;
                gbRedFolder.Enabled = false;
            }
            else checkBox1.Checked = true;
            nmbrFolders.Value = int.Parse(ss.folderRedundancy);
            tbDir.Text = ss.targetFolder;
            tbDir.WordWrap = true;

            if (ss.folderTimerEnabled.Equals("0"))
            {
                nmbrFolderTimer.Enabled = false;
            }
            else checkBox2.Checked = true;

            nmbrFolderTimer.Value = int.Parse(ss.folderTimerInterval);
            
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if( result == DialogResult.OK )
            {
                chosenDirectory = fbd.SelectedPath;
                tbDir.Text = chosenDirectory;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gbTarget.Enabled = true;
                gbRedFolder.Enabled = true;
            }
            else
            {
                gbTarget.Enabled = false;
                gbRedFolder.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                nmbrFolderTimer.Enabled = true;
            }
            else
            {
                nmbrFolderTimer.Enabled = false;
            }
        }

        private void cbFtpTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFtpTimer.Checked)
            {
                nmbrFtpTimer.Enabled = true;
            }
            else
            {
                nmbrFtpTimer.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string foldersEnabled;
            if (checkBox1.Checked) foldersEnabled = "1";
            else foldersEnabled = "0";
            string folderTimerEnabled;
            if (checkBox2.Checked) folderTimerEnabled = "1";
            else folderTimerEnabled = "0";

            SettingStructure saveSS = new SettingStructure(foldersEnabled, nmbrFolders.Value.ToString(), tbDir.Text,folderTimerEnabled, nmbrFolderTimer.Value.ToString());

            if (SettingsManager.saveSettings(saveSS)) MessageBox.Show("Settings saved succesfully");
            else MessageBox.Show("Error");
        }
    }
}
