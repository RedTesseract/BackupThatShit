using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupThatShit2
{
    public class SettingStructure
    {
        public string foldersEnabled;
        public string folderRedundancy;
        public string targetFolder;
        public string folderTimerEnabled;
        public string folderTimerInterval;

        public SettingStructure(string foldersEnabled,
        string folderRedundancy,
        string targetFolder,
        string folderTimerEnabled,
        string folderTimerInterval)
        {
            this.foldersEnabled = foldersEnabled;
            this.folderRedundancy = folderRedundancy;
            this.targetFolder = targetFolder;
            this.folderTimerEnabled = folderTimerEnabled;
            this.folderTimerInterval = folderTimerInterval;
        }
    }
}
