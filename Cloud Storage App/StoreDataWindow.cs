// -- Code by Vlaviano --

using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class StoreDataWindow : Form
    {
        public static string filePath;
        public static long cloudSize;

        public static long bytesRead = 0;
        public static long filesize = 0;
        public StoreDataWindow()
        {
            InitializeComponent();

            Client.getDirectorySize();

            //Setting the progress bar value using an algorith by Vlaviano Mario
            int procent_int = Convert.ToInt32((float)cloudSize / Client.cloudMaxSize * 100);
            float procent_float = (float)cloudSize / Client.cloudMaxSize * 100;
            pbar.Value = procent_int;
            procent_lbl.Text = procent_float.ToString("0.00") + "%";
            space_txt.Text = "Storage Available: " + ((float)cloudSize / 1024 / 1024 / 1024).ToString("0.00") + "GB / " + ((float)Client.cloudMaxSize / 1024 / 1024 / 1024).ToString("0.00") + "GB";
        }


        private void upload_btn_Click(object sender, EventArgs e)
        {
            if(path_txtbox.Text != "" && File.Exists(path_txtbox.Text))
            {
                if(filesize > 0)
                {
                    long sizeAvailable = Client.cloudMaxSize - cloudSize;
                    bool canStoreData = Client.checkSizeAvailability(sizeAvailable, path_txtbox.Text);
                    if (canStoreData)
                    {
                        upload_lbl2.Visible = true;
                        upload_pbar.Visible = true; //Setting the visibility for the uploading UI elements for upload progress status
                        upload_lbl.Visible = true;

                        uploadTimer.Enabled = true; //Progress bar and label update ****

                        Thread uploadThread = new Thread(() =>
                        {
                            Client.uploadFile(path_txtbox.Text);
                            if (path_txtbox.Text == filePath) //this statement checks if the file already exists
                            {
                                Action nextPage = () =>
                                {
                                    Thread.Sleep(4500); //waiting 3 seconds for sync between the UI and Push Notification

                                    CloudManager cloudManager = new CloudManager();
                                    cloudManager.Show();
                                    cloudManager.Closed += (s, args) => this.Close();
                                    this.Hide();

                                    //cleaning up....
                                    uploadTimer.Enabled = false;
                                    upload_pbar.Value = 0;
                                    upload_lbl.Text = "0.00";
                                    bytesRead = 0;
                                    filesize = 0;
                                };
                                this.BeginInvoke(nextPage);
                            }
                            else
                            {
                                Action refreshUI = () =>
                                {
                                    //Refreshing UI using a Action Class for removing a Cross-Thread error
                                    path_txtbox.Text = filePath;
                                    upload_pbar.Value = 0;
                                    upload_pbar.Visible = false;
                                    upload_lbl2.Visible = false;
                                    upload_lbl.Visible = false;
                                    filesize_lbl.Text = "- MB Filesize";
                                };
                                this.BeginInvoke(refreshUI);
                            }
                        });
                        uploadThread.Start();
                    }
                    else
                    {
                        CustomMessageBox msgBox = new CustomMessageBox();
                        msgBox.Show("You don't have enough space in the cloud!..Upgrade your account for unlimited access!");
                    }
                }
                else
                {
                    CustomMessageBox msgBox = new CustomMessageBox();
                    msgBox.Show("The file contains 0 Bytes! - Upload Error!");
                    filesize_lbl.Text = "- MB Filesize";
                    path_txtbox.Text = "";
                }                
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("File doesn't exist!");
            }
            
        }        

        private void browse_btn_Click(object sender, EventArgs e)
        {
            Client.browseFile();
            path_txtbox.Text = filePath;            
            filesize_lbl.Text = ((float)filesize / (1024 * 1024) > 1024) ? ((float)filesize / (1024 * 1024 * 1024)).ToString("0.00") + " GB Filesize" : ((float)filesize / (1024 * 1024)).ToString("0.00") + " MB Filesize";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu chooseWindow = new MainMenu();
            chooseWindow.Show();
            this.Hide();
            chooseWindow.Closed += (s, args) => this.Close();
        }

        private void uploadTimer_Tick(object sender, EventArgs e)
        {
            int upload_procent_pbar = (int)((float)bytesRead / filesize * 100);
            float upload_procent_lbl = (float)bytesRead / filesize * 100; 
            upload_pbar.Value = upload_procent_pbar;
            upload_lbl.Text = upload_procent_lbl.ToString("0.00") + "%";
        }
    }
}