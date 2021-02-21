// -- Code by Vlaviano -- //

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Cloud_Storage_App
{
    class Client
    {
        public static TcpClient clientSocket;
        public static NetworkStream networkStream;
        public static byte[] buffer = new byte[1024];
        public static byte[] outStream;
        public static string username = "";
        public static string password = "";
        public static long cloudMaxSize = 17179869184;
        public static string accountType = "Standard";
        public static long trashSize = 0;


        public void connectToServer()
        {
            clientSocket = new TcpClient();
            try
            {
                clientSocket.Connect("192.168.0.163", 8888);
                networkStream = clientSocket.GetStream();
            }catch(Exception e)
            {
                MessageBox.Show("Please check your internet connection: " + e.ToString());
            }
            // - - Connected to the server!
        }

        public static void disconnect()
        {
            outStream = Encoding.ASCII.GetBytes("disconnect");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            clientSocket.Close();
        }

        public static void register(string username, string password)
        {
            int bytesRead;

            //Sending the initial command
            outStream = Encoding.ASCII.GetBytes("register");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            //Sending the username
            outStream = Encoding.ASCII.GetBytes(username);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();


            bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            //These two lines are for making a sleep for writing data to server 
            string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            //this because the server was receiving all the data in a single variable | With all of these the bug is fixed

            if (data == "userReceived")
            {
                //Sending the password
                outStream = Encoding.ASCII.GetBytes(password);
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                //Getting the status from the server !
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string result = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                RegisterForm.status = result;

                Client.username = username;
                Client.password = password;

                settingsGathering();
            }
            else
            {
                //Getting the some info about the account  - usr/pass incorect - error
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string status = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                RegisterForm.status = status;
            }
        }

        public static void logIn(string username, string password, bool remember)
        {
            int bytesRead; 
            //Sending the initial command
            outStream = Encoding.ASCII.GetBytes("login");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(System.Environment.MachineName);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bytesRead = networkStream.Read(buffer, 0, buffer.Length); // sync machine received

            //Sending the username for login
            outStream = Encoding.ASCII.GetBytes(username);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            //These two lines are for making a sleep for writing data to server 
            string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            //this because the server was receiving all the data in a single variable | With all of these the bug is Fixed

            if (data == "userReceived")
            {
                //Sending the password for login
                outStream = Encoding.ASCII.GetBytes(password);
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                //Getting the info about the account password - if else
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string status = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                LogInForm.status = status;

                if (status == "Login Succesfully!")
                {
                    Client.username = username;
                    Client.password = password;

                    settingsGathering();

                    if (remember)
                        rememberMeON();
                }
            }
            else
            {
                //Getting the some info about the account  - usr/pass incorect - error
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string status = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                LogInForm.status = status;
            }          
        }
        public static bool rememberMeCheck()
        {
            int bytesRead;
            string rememberStatus = "2";

            outStream = Encoding.ASCII.GetBytes("rememberMeCheck");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bytesRead = networkStream.Read(buffer, 0, buffer.Length); // sync cmd received

            outStream = Encoding.ASCII.GetBytes(System.Environment.MachineName);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bytesRead = networkStream.Read(buffer, 0, buffer.Length); // sync machine received

            do
            {
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                rememberStatus = Encoding.ASCII.GetString(buffer, 0, bytesRead); //sync

                outStream = Encoding.ASCII.GetBytes("done");
                networkStream.Write(outStream, 0, outStream.Length); //sync
                networkStream.Flush();
            } while (rememberStatus == "2");

            if(rememberStatus == "1")
            {
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string username = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                outStream = Encoding.ASCII.GetBytes("userReceived");
                networkStream.Write(outStream, 0, outStream.Length); //sync
                networkStream.Flush();

                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string password = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                Client.username = username;
                Client.password = password;

                settingsGathering();

                return true;
            }
            else
            {
                return false;
            }
        }
        public static void rememberMeON()
        {
            outStream = Encoding.ASCII.GetBytes("rememberMeON");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length); //sync

            outStream = Encoding.ASCII.GetBytes(System.Environment.MachineName);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();
        }
        public static void logout()
        {
            outStream = Encoding.ASCII.GetBytes("logout");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(System.Environment.MachineName);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int byteRead = networkStream.Read(buffer, 0, buffer.Length);

            disconnect();
        }
        public static void settingsGathering()
        {
            List<string> list = new List<string>();
            int interation = 1;
            while (interation <= 3)
            {
                int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string setting = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                list.Add(setting);

                outStream = Encoding.ASCII.GetBytes("pass");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                interation++;
            }
            string[] settings = list.ToArray();

            //Max Cloud Size: [0]
            //Account Type: [1]
            //TrashBin Size: [2]

            cloudMaxSize = Int64.Parse(settings[0]);
            accountType = settings[1];
            trashSize = Int64.Parse(settings[2]);
        }

        public static void browseFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
		        openFileDialog.RestoreDirectory = true;
		        if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StoreDataWindow.filePath = openFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    StoreDataWindow.filesize = (long)fileInfo.Length;
                }
            }
        }

        public static void getDirectorySize()
        {
            outStream = Encoding.ASCII.GetBytes("dir size");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            long dirSize = Convert.ToInt64(Encoding.ASCII.GetString(buffer, 0, bytesRead));
            StoreDataWindow.cloudSize = dirSize;
            CloudManager.cloudSize = dirSize;
        }

        public static bool checkSizeAvailability(long sizeAvailable, string file_path)
        {
            FileInfo info = new FileInfo(file_path);
            if(info.Length <= sizeAvailable)
                return true;
            else
                return false;
        }

        public static void uploadFile(string filePath)
        {
            outStream = Encoding.ASCII.GetBytes("uploadFile");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            FileInfo fileInfo = new FileInfo(filePath); // Getting all the informations i need for upload
            string filename = fileInfo.Name;
            long filesize = fileInfo.Length;
            StoreDataWindow.filesize = filesize;

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead2 = networkStream.Read(buffer, 0, buffer.Length);
            string response = Encoding.ASCII.GetString(buffer, 0, bytesRead2);

            if (response == "Filename Received")
            {
                outStream = Encoding.ASCII.GetBytes(filesize.ToString());
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                using (FileStream f = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[65536];
                    long bytesToRead = f.Length;
                    long bytesRead = 0;

                    while (bytesToRead > 0)
                    {
                        f.Seek(bytesRead, SeekOrigin.Begin);
                        int data = f.Read(bytes, 0, 65536);

                        if (data == 0)
                            break;

                        bytesRead += data;
                        bytesToRead -= data;

                        StoreDataWindow.bytesRead = bytesRead;

                        //Sending the bytes without encoding...
                        networkStream.Write(bytes, 0, bytes.Length);
                        networkStream.Flush();
                    }
                }
                ToastNotification.RunUploadNotificationPythonScript();
            }
            else
            {
                //File already exists!
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show(response);
                StoreDataWindow.filePath = "";
            }  
        }

        public static void getStoredFilenames()
        {
            outStream = Encoding.ASCII.GetBytes("getFilenames");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            int totalFiles = Int32.Parse(Encoding.ASCII.GetString(buffer,0,bytesRead));

            List<string> list = new List<string>();

            for (int iteration = 1; iteration <= totalFiles; iteration++)
            {
                list.Add(Encoding.ASCII.GetString(buffer, 0, networkStream.Read(buffer, 0, buffer.Length)));

                networkStream.Write(outStream, 0, Encoding.ASCII.GetBytes("next").Length);
                networkStream.Flush();
            }
            string[] filenames = list.ToArray();
            CloudManager.files = filenames;
            DownloadWindow.files = filenames;
        }

        public static void getTrashFilenames()
        {
            outStream = Encoding.ASCII.GetBytes("getTrashFilenames");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            int totalFiles = Int32.Parse(Encoding.ASCII.GetString(buffer, 0, bytesRead));

            List<string> list = new List<string>();

            for (int iteration = 1; iteration <= totalFiles; iteration++)
            {
                list.Add(Encoding.ASCII.GetString(buffer, 0, networkStream.Read(buffer, 0, buffer.Length)));

                networkStream.Write(outStream, 0, Encoding.ASCII.GetBytes("next").Length);
                networkStream.Flush();
            }
            string[] filenames = list.ToArray();
            TrashForm.filenames = filenames;
            TrashForm.totalItems = totalFiles;
        }

        public static int getTrashSize()
        {
            outStream = Encoding.ASCII.GetBytes("getTrashSize");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            int totalFiles = Int32.Parse(Encoding.ASCII.GetString(buffer, 0, bytesRead));

            return totalFiles;
        }

        public static void upgradeAccount()
        {
            outStream = Encoding.ASCII.GetBytes("upgradeAccount");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            settingsGathering();
        }

        public static void fileDetails(string filename)
        {
            outStream = Encoding.ASCII.GetBytes("fileDetails");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            List<string> list = new List<string>();

            int iteration = 0;
            while (iteration <= 3)
            {
                int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                list.Add(data);

                outStream = Encoding.ASCII.GetBytes("pass");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                iteration++;
            }
            string[] properties = list.ToArray();

            FileDetailsWindow.filename = properties[0];
            FileDetailsWindow.date_time = properties[1];
            FileDetailsWindow.filesize = properties[2];
            FileDetailsWindow.filetype = properties[3];
        }

        public static void deleteFile(string filename)
        {
            byte[] buffer = new byte[4096];

            outStream = Encoding.ASCII.GetBytes("deleteFile");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            settingsGathering();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length); //Reading the status - (sync)
            CloudManager.status = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        }

        public static void deleteTrash()
        {
            byte[] buffer = new byte[4096];

            outStream = Encoding.ASCII.GetBytes("deleteTrash");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            settingsGathering();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length); //sync
        }
        public static void deleteTrashFile(string filename)
        {
            byte[] buffer = new byte[4096];

            outStream = Encoding.ASCII.GetBytes("deleteTrashFile");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            settingsGathering();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length); //sync
        }
        public static void restoreTrashFile(string filename)
        {
            byte[] buffer = new byte[4096];

            outStream = Encoding.ASCII.GetBytes("restoreTrashFile");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            settingsGathering();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length); //sync
        }

        public static bool lookForDirectory(string dir)
        {
            if (Directory.Exists(dir))
                return true;
            else
                return false;
        }

        public static long getDownloadFileSize(string filename)
        {
            outStream = Encoding.ASCII.GetBytes("getDownloadFileSize");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            long filesize = Int64.Parse(Encoding.ASCII.GetString(buffer, 0, bytesRead));

            return filesize;
        }

        public static bool diskSpaceAvailability(string filename,string path,long filesize)
        {
            string driveLetter = path[0] + @":\";

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
            {
                if(drive.Name == driveLetter)
                {
                    if (filesize < drive.AvailableFreeSpace)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public static void downloadFile(string filename,bool deleteFile,string output_path,bool notify)
        {
            byte[] receive_buffer = new byte[4096];
            int bufferBytesRead = 0;
            
            outStream = Encoding.ASCII.GetBytes("downloadFile");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int deleteOption = Convert.ToInt32(deleteFile); //Converting bool to int 
            outStream = Encoding.ASCII.GetBytes(deleteOption.ToString());
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bufferBytesRead = networkStream.Read(receive_buffer, 0, receive_buffer.Length); //Sync

            outStream = Encoding.ASCII.GetBytes(filename);
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();


            bufferBytesRead = networkStream.Read(receive_buffer, 0, receive_buffer.Length); //Sync
            long filesize = Int64.Parse(Encoding.ASCII.GetString(receive_buffer, 0, bufferBytesRead));
            DownloadWindow.filesize = filesize;

            using (FileStream file = new FileStream(output_path + @"\" + filename, FileMode.Create, FileAccess.Write))
            {
                byte[] file_buffer = new byte[65536];
                long bytesToWrite = filesize;
                long bytesWrite = 0;

                while(bytesToWrite > 0)
                {
                    int data = networkStream.Read(file_buffer, 0, file_buffer.Length);
                    
                    if (data == 0)
                        break;
                    
                    file.Seek(bytesWrite, SeekOrigin.Begin);
                    file.Write(file_buffer, 0, data);
                    
                    bytesToWrite -= data;
                    bytesWrite += data;

                    DownloadWindow.bytesWrite = bytesWrite;
                    LoadingScreen.bytesWrite = bytesWrite;
                }
            }
            if(notify)
                ToastNotification.RunDownloadNotificationPythonScript();
        }
        public static void previewFile(string filename)
        {
            //Setting the variables
            string temp_path = Path.GetTempPath();
            string fileType = filename.Substring(filename.LastIndexOf(".") + 1);
            Process proc = new Process();

            downloadFile(filename, false, temp_path, false); // Processing file

            if (fileType == "png" || fileType == "jpg" || fileType == "JPG" || fileType == "jpeg")
            {
                string root_path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string cmd = String.Format(
                        "\"{0}{1}\", ImageView_Fullscreen {2}",
                        Environment.Is64BitOperatingSystem ?
                            root_path :
                            root_path.Replace(" (x86)", ""),
                        @"\Windows Photo Viewer\PhotoViewer.dll",
                        temp_path + filename);

                var psi = new ProcessStartInfo(
                    "rundll32.exe",
                    cmd
                ); 

                psi.UseShellExecute = false;

                var viewer = Process.Start(psi);

                viewer.EnableRaisingEvents = true;
                viewer.Exited += new EventHandler((sender, e) => myProcess_Exited(sender, e, temp_path, filename));
            }
            else if(fileType == "pdf")
            {
                string root_path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string cmd = String.Format(
                        "\"{0}{1}\" {2}",
                        Environment.Is64BitOperatingSystem ?
                            root_path:
                            root_path.Replace(" (x86)", ""),
                        @"\Microsoft\Edge\Application\msedge.exe",
                        "\"" + "file:////" + temp_path.Replace(@"\","/") + filename + "\"");

                var psi = new ProcessStartInfo(cmd);
                psi.UseShellExecute = false;

                var viewer = Process.Start(psi);

                viewer.EnableRaisingEvents = true;
                viewer.Exited += new EventHandler((sender, e) => myProcess_Exited(sender, e, temp_path, filename));
            }
            else if (fileType == "mp3" || fileType == "mp4")
            {
                string root_path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string cmd = String.Format(
                        "\"{0}{1}\" {2}",
                        Environment.Is64BitOperatingSystem ?
                            root_path :
                            root_path.Replace(" (x86)", ""),
                        @"\Windows Media Player\wmplayer.exe",
                        "\"" + temp_path + filename + "\"");

                var psi = new ProcessStartInfo(cmd);
                psi.UseShellExecute = false;

                var viewer = Process.Start(psi);

                viewer.EnableRaisingEvents = true;
                viewer.Exited += new EventHandler((sender, e) => myProcess_Exited(sender, e, temp_path, filename));
            }
            else
            {
                try
                {
                    proc = Process.Start(temp_path.Replace(@"\", @"\\") + filename);
                    proc.EnableRaisingEvents = true;
                    proc.Exited += new EventHandler((sender, e) => myProcess_Exited(sender, e, temp_path, filename));
                }
                catch(Exception e)
                {
                    File.Delete(temp_path.Replace(@"\", @"\\") + filename);
                    MessageBox.Show("There is no associated program to the file type: " + e);
                }
            }
        }
        private static void myProcess_Exited(object sender, System.EventArgs e,string temp_path,string filename)
        {
            File.Delete(temp_path.Replace(@"\", @"\\") + filename);
        }
    }
}
