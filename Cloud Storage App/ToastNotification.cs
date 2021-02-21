using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace Cloud_Storage_App
{
    public class ToastNotification
    {
        public static void RunUploadNotificationPythonScript()
        {
            //Getting the working dir which is the bin/debug folder 
            string workingDir = Directory.GetCurrentDirectory();
            //and then i will get the parent(2x) of that folder to get to the root of my app -- Code by Vlaviano -- 
            string projectDir = workingDir + @"\" + "Python Scripts" + @"\";

            Process script = new Process();
            script.StartInfo.FileName = projectDir.Replace(@"\", @"\\") + "PushNotificationUpload.exe";
            script.StartInfo.UseShellExecute = false; // utilizarea Terminalului Windows (Command Prompt) -> pentru fisiere .py, .js, .jar etc.
            script.Start();
        }
        public static void RunDownloadNotificationPythonScript()
        {
            //Getting the working dir which is the bin/debug folder 
            string workingDir = Directory.GetCurrentDirectory();
            //and then i will get the parent(2x) of that folder to get to the root of my app -- Code by Vlaviano -- 
            string projectDir = workingDir + @"\" + "Python Scripts" + @"\";

            Process script = new Process();
            script.StartInfo.FileName = projectDir.Replace(@"\", @"\\") + "PushNotificationDownload.exe";
            script.StartInfo.UseShellExecute = false; // utilizarea Terminalului Windows (Command Prompt) -> pentru fisiere .py, .js, .jar etc.
            script.Start();
        }
    }
}
