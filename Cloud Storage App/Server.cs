// -- Code by Vlaviano -- //

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace Cloud_Storage_App
{
    class Server
    {
        public IPAddress localIP;

        public int port = 8888;

        public static TcpListener serverSocket;
        public static TcpClient clientSocket;
        public static int clientsConnected = 0;

        public static string accounts_path = "D:/Server Files";
        public static string rememberMeFilePath = @"D:\Server Files\RememberMeSystem.txt";

        public void getIp()
        {
            var hostName = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in hostName.AddressList)
            {
                ServerWindow.ip = ip.ToString();
                localIP = ip;
            }
        }

        public async Task createServerAsync()
        {
            serverSocket = new TcpListener(localIP, port);
            clientSocket = default(TcpClient);
            int clientCounter = 0;
            try
            {
                serverSocket.Start();
                //Server connected!
                await Task.Run(()=> 
                { 
                    clientCounter = 0;
                    while (true)
                    {
                        try
                        {
                            clientSocket = serverSocket.AcceptTcpClient();
                        }
                        catch(SocketException e)
                        {
                            MessageBox.Show("Error on accepting clients! - " + e);
                            serverSocket.Stop();
                            Application.Exit();
                        }
                        //Client is now connected to the server!
                        clientCounter++;
                        clientsConnected++;
                        handleClient client = new handleClient();
                        client.startClient(clientSocket, Convert.ToString(clientCounter));
                    }
                });
            }
            catch (Exception e)
            {
                MessageBox.Show("Error on creating server: " + e);
                serverSocket.Stop();
            }
        }
    }
    public class handleClient
    {
        TcpClient clientSocket;
        string clientNumber;
        NetworkStream networkStream;
        string acc_path = "";

        //.txt document
        public static long cloudSize = 17179869184;
        public static string accountType = "Standard";
        public static long trashSize = 0;
        public static string[] accountSettings = new string[] { cloudSize.ToString(), accountType, trashSize.ToString() };
        //--------

        //Personal DATA:
        public static string Client_username;
        public static string Client_password;
        //-----------------


        public void startClient(TcpClient inClientSocket, string clientNo)
        {
            this.clientSocket = inClientSocket;
            this.clientNumber = clientNo;
            networkStream = clientSocket.GetStream();
            //MessageBox.Show("A new client has connected!");
            Thread getCommandsThread = new Thread(getCommands);
            getCommandsThread.Start();
        }
        
        public void getCommands() 
        {
            string cmd = "";
            int bytesRead;
            byte[] buffer = new byte[1024];

            try
            {
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                cmd = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            }
            catch
            {
                //this catch is active only when a client is disconnected!
                Console.WriteLine("Client Disconnected");

                clientSocket.Close();
                Server.clientsConnected--;
            }

            //List of available commands//

            if (cmd == "disconnect") disconnectClient();
            if (cmd == "register") registerAccount();
            if (cmd == "login") logInAccount();
            if (cmd == "rememberMeON") rememberMeON();
            if (cmd == "rememberMeCheck") rememberMeCheck();
            if (cmd == "logout") logout();
            if (cmd == "dir size") dirSize();
            if (cmd == "uploadFile") storeData();
            if (cmd == "getFilenames") getFilenames();
            if (cmd == "upgradeAccount") upgradeClientAccount();
            if (cmd == "fileDetails") fileDetails();
            if (cmd == "deleteFile") deleteFile();
            if (cmd == "getTrashFilenames") getTrashFilenames();
            if (cmd == "getTrashSize") getTrashSize();
            if (cmd == "deleteTrash") deleteTrash();
            if (cmd == "deleteTrashFile") deleteTrashFile();
            if (cmd == "restoreTrashFile") restoreTrashFile();
            if (cmd == "downloadFile") sendFileToClient();
            if (cmd == "getDownloadFileSize") getDownloadFileSize();
        }
        public void disconnectClient()
        {
            Console.WriteLine("Client Has Disconnected!");

            clientSocket.Close();
            Server.clientsConnected--;
        }
        public void upgradeClientAccount()
        {
            //upgrading the cloudSize and accountType
            cloudSize = cloudSize + (1024 * 1024 * 1024);
            accountSettings = new string[] { cloudSize.ToString(), accountType, trashSize.ToString() };
            //16 - 20 Standard 
            //20 - 32 Silver
            //32 - 64 Gold
            //64 - ~ Premium

            if (cloudSize < 21474836480) accountType = "Standard";
            else if (cloudSize >= 21474836480 && cloudSize < 34359738368) accountType = "Silver";
            else if (cloudSize >= 34359738368 && cloudSize < 68719476736) accountType = "Gold";
            else if (cloudSize >= 68719476736) accountType = "Premium";
            else accountType = "Unknown";
            
            File.Delete(Directory.GetParent(acc_path).ToString() + "/userSettings.txt");
            generateUserSettingsFile();

            accountSettingsGathering();

            getCommands();
        }


        public void generateUserSettingsFile()
        {
            //Max Cloud Size: [0]
            //Account Type: [1]
            //TrashBin Size: [2]

            cloudSize = 17179869184;
            accountType = "Standard";
            trashSize = 0;

            accountSettings = new string[] { cloudSize.ToString(), accountType, trashSize.ToString() };

            FileStream f = File.Create(Directory.GetParent(acc_path) + "/userSettings.txt");
            f.Close();

            File.WriteAllLines(f.Name, accountSettings);
        }

        
        public void accountSettingsGathering()
        {
            byte[] buffer = new byte[4096];

            string[] list = File.ReadAllLines(Directory.GetParent(acc_path) + "/userSettings.txt");

            cloudSize = Int64.Parse(list[0]);
            accountType = list[1];
            trashSize = Int64.Parse(list[2]);

            accountSettings = new string[] { cloudSize.ToString(), accountType, trashSize.ToString() };

            foreach (string setting in accountSettings)
            {
                byte[] outStream = Encoding.ASCII.GetBytes(setting);
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            }
        }

        public void fileDetails()
        {
            byte[] buffer = new byte[4096];
            
            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string filename = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            string date_time = File.GetCreationTime(acc_path + "/" + filename).ToString();
            
            FileInfo fileInfo = new FileInfo(acc_path + "/" + filename);
            string filesize = fileInfo.Length.ToString();
            string fileType = filename.Substring(filename.LastIndexOf(".") + 1);


            string[] list = new string[] { filename.Substring(0, filename.LastIndexOf(".")),date_time,filesize,fileType };

            int iteration = 0;
            while (iteration <= 3)
            {
                byte[] outStream = Encoding.ASCII.GetBytes(list[iteration]);
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                bytesRead = networkStream.Read(buffer, 0, buffer.Length);

                iteration++;
            }
            getCommands();
        }

        public void registerAccount()
        {
            string data;
            byte[] outStream;
            int bytesRead = 0;
            byte[] buffer = new byte[clientSocket.ReceiveBufferSize];

            bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            string username = data;
            acc_path = Server.accounts_path + "/" + username;

            if (Directory.Exists(acc_path) == false)
            {
                outStream = Encoding.ASCII.GetBytes("userReceived");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                Directory.CreateDirectory(acc_path); // this line creates a directory in a specified folder (like a database)

                //Getting the password & creating the folder for the password
                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                string password = data;
                acc_path = acc_path + "/" + password;
                    
                Directory.CreateDirectory(acc_path); // this line creates a folder in the username folder named with the password
               
                //Sending the response
                outStream = Encoding.ASCII.GetBytes("Account was created Succesfully!");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                generateUserSettingsFile();//.txt file for saving the variables

                accountSettingsGathering();//sending the settings to user client

                Client_username = username;
                Client_password = password;

                getCommands();
            }
            else
            {
                outStream = Encoding.ASCII.GetBytes("userIncorect");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                outStream = Encoding.ASCII.GetBytes("Account already exists. Try again!");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();
                
                getCommands();
            }
        }
        public void logInAccount()
        {
            string data;
            int bytesRead;
            byte[] buffer = new byte[clientSocket.ReceiveBufferSize];
            byte[] outStream;

            bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string machine_name = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            outStream = Encoding.ASCII.GetBytes("machine received");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            string username = data;
            acc_path = Server.accounts_path + "/" + username;

            if (Directory.Exists(acc_path))
            {
                outStream = Encoding.ASCII.GetBytes("userReceived");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                string password = data;
                acc_path = acc_path + "/" + password;
                if (Directory.Exists(acc_path))
                {
                    outStream = Encoding.ASCII.GetBytes("Login Succesfully!");
                    networkStream.Write(outStream, 0, outStream.Length);
                    networkStream.Flush();

                    accountSettingsGathering();//sending the settings to user client

                    Client_username = username;
                    Client_password = password;

                    getCommands();
                }
                else
                {
                    outStream = Encoding.ASCII.GetBytes("Incorect Password!");
                    networkStream.Write(outStream, 0, outStream.Length);
                    networkStream.Flush();
                    getCommands();
                }
            }
            else
            {
                outStream = Encoding.ASCII.GetBytes("userIncorect");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();


                outStream = Encoding.ASCII.GetBytes("Account doesn't exists!");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                getCommands();
            }
        }

        public void rememberMeON()
        {
            byte[] buffer = new byte[4096];

            byte[] outStream = Encoding.ASCII.GetBytes("turnRememberON");//sync
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush(); 

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string machineName = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            using (StreamWriter dataFile = new StreamWriter(Server.rememberMeFilePath, true))
            {
                dataFile.WriteLine(machineName + "|" + Client_username + "|" + Client_password);
            }

            getCommands();
        }
        public void rememberMeCheck()
        {
            byte[] buffer = new byte[4096];
            byte[] outStream;
            int bytesRead;
            bool userFound = false;

            outStream = Encoding.ASCII.GetBytes("checkForAvailableLogin");//sync
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string machineName = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            outStream = Encoding.ASCII.GetBytes("machine received");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            string[] lines = File.ReadAllLines(Server.rememberMeFilePath);

            foreach (string line in lines)
            {
                if (line.Contains(machineName))
                {
                    outStream = Encoding.ASCII.GetBytes("1");
                    networkStream.Write(outStream, 0, outStream.Length);
                    networkStream.Flush();

                    bytesRead = networkStream.Read(buffer, 0, buffer.Length);//sync

                    Client_username = line.Substring(machineName.Length + 1, line.Length - machineName.Length + 1 - (line.Length - line.LastIndexOf("|") + 2)); ;
                    Client_password = line.Substring(line.LastIndexOf("|") + 1);

                    outStream = Encoding.ASCII.GetBytes(Client_username);
                    networkStream.Write(outStream, 0, outStream.Length);
                    networkStream.Flush();

                    bytesRead = networkStream.Read(buffer, 0, buffer.Length); //sync

                    outStream = Encoding.ASCII.GetBytes(Client_password);
                    networkStream.Write(outStream, 0, outStream.Length);
                    networkStream.Flush();

                    acc_path = Server.accounts_path + "/" + Client_username + "/" + Client_password;

                    userFound = true;

                    accountSettingsGathering();

                    break;
                }
                else
                {
                    outStream = Encoding.ASCII.GetBytes("2"); //sync
                    networkStream.Write(outStream, 0, outStream.Length);
                    networkStream.Flush();

                    bytesRead = networkStream.Read(buffer, 0, buffer.Length);//sync
                }
            }
            if (userFound == false)
            {
                outStream = Encoding.ASCII.GetBytes("0"); //sync
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                bytesRead = networkStream.Read(buffer, 0, buffer.Length);//sync
            }
            getCommands();
        }
        public void logout()
        {
            byte[] buffer = new byte[4096];
            string tempFile = Path.GetTempFileName();

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string machineName = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            string[] lines = File.ReadAllLines(Server.rememberMeFilePath);
            StreamWriter sw = new StreamWriter(tempFile);                 

            foreach (string line in lines)
            {
                if (line.Contains(machineName))
                    Console.WriteLine("Delete line!");
                else
                    sw.WriteLine(line);
            }
            sw.Close();

            File.Delete(Server.rememberMeFilePath);
            File.Move(tempFile, Server.rememberMeFilePath);

            byte[] outStream = Encoding.ASCII.GetBytes("done"); //sync
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            getCommands();
        }

        public void dirSize()
        {
            //TODO: Directory size - remove foreach file

            string[] files = Directory.GetFiles(acc_path);
            long totalSize = 0;
            foreach(string file in files)
            {
                
                FileInfo info = new FileInfo(file);
                totalSize += info.Length;
            }
            if (Directory.Exists(acc_path + @"\trash\"))
            {
                files = Directory.GetFiles(acc_path + @"\trash\");
                foreach(string file in files)
                {
                    FileInfo f = new FileInfo(file);
                    totalSize += f.Length;
                }
            }
            //Sending the total dir size
            byte[] outStream = Encoding.ASCII.GetBytes(totalSize.ToString());
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            getCommands();
        }

        public void storeData()
        {
            byte[] buffer = new byte[clientSocket.ReceiveBufferSize]; //setting a buffer for file information receive
            int com_bytesRead;

            com_bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string filename = Encoding.ASCII.GetString(buffer, 0, com_bytesRead);

            if(File.Exists(acc_path + @"\" + filename) || File.Exists(acc_path + @"\trash\" + filename))
            {
                byte[] outStream = Encoding.ASCII.GetBytes("File already exists!");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();
            }
            else
            {
                byte[] outStream = Encoding.ASCII.GetBytes("Filename Received");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                com_bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                long filesize = Int64.Parse(Encoding.ASCII.GetString(buffer, 0, com_bytesRead));

                using (FileStream f = new FileStream(acc_path + @"\" + filename, FileMode.Create, FileAccess.Write))
                {
                    byte[] fileBuffer = new byte[65536];
                    long bytesToWrite = filesize;
                    long bytesWrite = 0;
                    int data = 0;

                    while (bytesToWrite > 0)
                    {
                        data = networkStream.Read(fileBuffer, 0, fileBuffer.Length); //Getting the bytes for writing the file
                        if (data == 0)
                            break;

                        f.Seek(bytesWrite, SeekOrigin.Begin);
                        f.Write(fileBuffer, 0, data);

                        bytesWrite += data;
                        bytesToWrite -= data;
                    }
                }
            }            
            getCommands();
        }

        public void getFilenames()
        {
            byte[] buffer = new byte[clientSocket.ReceiveBufferSize];

            DirectoryInfo dirInfo = new DirectoryInfo(acc_path);
            FileInfo[] filesInfo = dirInfo.GetFiles();

            byte[] outStream = Encoding.ASCII.GetBytes(dirInfo.GetFiles().Length.ToString());
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            foreach (FileInfo fileInfo in filesInfo)
            {
                outStream = Encoding.ASCII.GetBytes(fileInfo.Name);
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                int bytes = networkStream.Read(buffer, 0, buffer.Length);
            }
            getCommands();
        }

        public void getTrashFilenames()
        {
            byte[] buffer = new byte[clientSocket.ReceiveBufferSize];

            DirectoryInfo dirInfo = new DirectoryInfo(acc_path + @"\trash\");
            FileInfo[] filesInfo = dirInfo.GetFiles();

            byte[] outStream = Encoding.ASCII.GetBytes(dirInfo.GetFiles().Length.ToString());
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            foreach (FileInfo fileInfo in filesInfo)
            {
                outStream = Encoding.ASCII.GetBytes(fileInfo.Name);
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();

                int bytes = networkStream.Read(buffer, 0, buffer.Length);
            }
            getCommands();
        }

        public void getTrashSize()
        {
            byte[] buffer = new byte[clientSocket.ReceiveBufferSize];
            if(Directory.Exists(acc_path + @"\trash\"))
            {

                DirectoryInfo dir = new DirectoryInfo(acc_path + @"\trash\");        

                byte[] outStream = Encoding.ASCII.GetBytes(dir.GetFiles().Length.ToString());
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();
            }
            else
            {
                byte[] outStream = Encoding.ASCII.GetBytes(0.ToString());
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();
            }
            getCommands();
        }


        public void deleteFile()
        {           
            byte[] buffer = new byte[4096];
            byte[] outStream;

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string filename = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            if(File.Exists(acc_path + @"\" + filename))
            {
                FileInfo f = new FileInfo(acc_path + @"\" + filename);

                if (Directory.Exists(acc_path + @"\" + "trash") == false)
                    Directory.CreateDirectory(acc_path + @"\" + "trash");
                else { }

                f.MoveTo(acc_path + @"\trash\" + filename);
                trashSize = trashSize + Convert.ToInt64(f.Length);

                //Restarting Statistics
                File.Delete(Directory.GetParent(acc_path).ToString() + "/userSettings.txt");
                generateUserSettingsFile();
                accountSettingsGathering();

                outStream = Encoding.ASCII.GetBytes("File was deleted!");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();
            }
            else
            {
                outStream = Encoding.ASCII.GetBytes("File doesn't exist! - Fail");
                networkStream.Write(outStream, 0, outStream.Length);
                networkStream.Flush();
            }
            getCommands();
        }

        public void deleteTrash()
        {
            byte[] buffer = new byte[4096];
            byte[] outStream;

            DirectoryInfo dir = new DirectoryInfo(acc_path + @"/trash/");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                trashSize = trashSize - Convert.ToInt64(file.Length);
                file.Delete();
            }

            //Restarting Statistics
            File.Delete(Directory.GetParent(acc_path).ToString() + "/userSettings.txt");
            generateUserSettingsFile();
            accountSettingsGathering();

            outStream = Encoding.ASCII.GetBytes("File was restored!");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            getCommands();
        }
        public void deleteTrashFile()
        {
            byte[] buffer = new byte[4096];
            byte[] outStream;

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string filename = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            FileInfo f = new FileInfo(acc_path + @"/trash/" + filename);
            trashSize = trashSize - Convert.ToInt64(f.Length);
            f.Delete();

            //Restarting Statistics
            File.Delete(Directory.GetParent(acc_path).ToString() + "/userSettings.txt");
            generateUserSettingsFile();
            accountSettingsGathering();

            outStream = Encoding.ASCII.GetBytes("File was restored!");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            getCommands();
        }
        public void restoreTrashFile()
        {
            byte[] buffer = new byte[4096];
            byte[] outStream;

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string filename = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            FileInfo f = new FileInfo(acc_path + @"\trash\" + filename);
            f.MoveTo(acc_path + @"\" + filename);
            trashSize = trashSize - Convert.ToInt64(f.Length);

            //Restarting Statistics
            File.Delete(Directory.GetParent(acc_path).ToString() + "/userSettings.txt");
            generateUserSettingsFile();
            accountSettingsGathering();

            outStream = Encoding.ASCII.GetBytes("File was restored!");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            getCommands();
        }

        public void getDownloadFileSize()
        {
            byte[] buffer = new byte[4096];
            byte[] outStream;

            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string filename = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            FileInfo file = new FileInfo(acc_path + @"\" + filename);

            outStream = Encoding.ASCII.GetBytes(file.Length.ToString());
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            getCommands();
        }

        public void sendFileToClient()
        {
            byte[] receive_buffer = new byte[4096];
            byte[] outStream;

            int optionBytes = networkStream.Read(receive_buffer, 0, receive_buffer.Length);
            int deleteOption = Int32.Parse(Encoding.ASCII.GetString(receive_buffer, 0,optionBytes));
            // First i will convert to int and then i will convert the int to -> bool 
            // This code can be little ambiguous but it is working VERY WELL

            outStream = Encoding.ASCII.GetBytes("optionReceived"); //Made for sync - ;)
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            int filenameBytes = networkStream.Read(receive_buffer, 0, receive_buffer.Length);
            string filename = Encoding.ASCII.GetString(receive_buffer, 0, filenameBytes);

            FileInfo fileInfo = new FileInfo(acc_path + @"\" + filename);
            string filePath = fileInfo.FullName;
            long filesize = fileInfo.Length;

            outStream = Encoding.ASCII.GetBytes(filesize.ToString()); //Made for sync - ;)
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] file_buffer = new byte[65536];
                long bytesToRead = file.Length;
                long bytesRead = 0;
                
                while(bytesToRead > 0)
                {
                    file.Seek(bytesRead, SeekOrigin.Begin);
                    int data = file.Read(file_buffer, 0, 65536);
                    if (data == 0)
                        break;
                    bytesRead += data;
                    bytesToRead -= data;
                    networkStream.Write(file_buffer, 0, file_buffer.Length);
                    networkStream.Flush();
                }
            }
            
            if (deleteOption == 1)
                File.Delete(filePath);
            else { } //do Nothing :)

            getCommands();
        }
    }
}