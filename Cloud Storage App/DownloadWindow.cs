using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class DownloadWindow : Form
    {
        public static string[] files = new string[] { "" };
        public static long filesize = 0;
        public static long bytesWrite = 0;

        public DownloadWindow()
        {
            InitializeComponent();

            //Adding file names in comboBox
            Client.getStoredFilenames();
            foreach (string file in files)
                file_combo.Items.Add(file);
            if (file_combo.Items.Count == 0) file_combo.Text = " - - - It look like your cloud is empty! - - - ";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            mainMenu.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void file_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filetype = file_combo.Text.Substring(file_combo.Text.LastIndexOf(".") + 1);
            if (filetype == "zip" || filetype == "rar") fileType_ic.Image = new Bitmap(Properties.Resources.winrar_ic);
            else if (filetype == "doc" || filetype == "docx") fileType_ic.Image = new Bitmap(Properties.Resources.word_ic);
            else if (filetype == "xlsx" || filetype == "xls") fileType_ic.Image = new Bitmap(Properties.Resources.excel_ic);
            else if (filetype == "ppt" || filetype == "pptx") fileType_ic.Image = new Bitmap(Properties.Resources.ppt_ic);
            else if (filetype == "mp4") fileType_ic.Image = new Bitmap(Properties.Resources.mp4_ic);
            else if (filetype == "mp3") fileType_ic.Image = new Bitmap(Properties.Resources.mp3_ic);
            else if (filetype == "png" || filetype == "jpg" || filetype == "JPG" || filetype == "jpeg") fileType_ic.Image = new Bitmap(Properties.Resources.photo_ic);
            else if (filetype == "txt" || filetype == "log") fileType_ic.Image = new Bitmap(Properties.Resources.txt_ic);
            else if (filetype == "pdf") fileType_ic.Image = new Bitmap(Properties.Resources.pdf_ic);
            else fileType_ic.Image = new Bitmap(Properties.Resources.unknownFile_ic);

            if (file_combo.Text != "  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " && file_combo.Text != " - - - It look like your cloud is empty! - - - " && file_combo.Text != "")
                download_btn.Visible = true;
            else
                download_btn.Visible = false;
            
            filesize_lbl.Text = ((float)Client.getDownloadFileSize(file_combo.Text) / (1024 * 1024) > 1024) ? ((float)Client.getDownloadFileSize(file_combo.Text) / (1024 * 1024 * 1024)).ToString("0.00") + " GB Filesize" : ((float)Client.getDownloadFileSize(file_combo.Text) / (1024 * 1024)).ToString("0.00") + " MB Filesize";
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            if (Client.diskSpaceAvailability(file_combo.Text,path_txtbox.Text,filesize) == true)
            {
                if (Client.lookForDirectory(path_txtbox.Text) == true)
                {
                    download_lbl2.Visible = true;
                    download_pbar.Visible = true; //Setting the visibility for the downloading UI elements for download progress status
                    download_lbl.Visible = true;

                    downloadTimer.Enabled = true; //Progress bar and label update ****

                    string filename = file_combo.Text;

                    Thread downloadThread = new Thread(() => {

                        Client.downloadFile(filename, deleteFileCheckBox.Checked, path_txtbox.Text, true);
                        Action nextPage = () =>
                        {
                            Thread.Sleep(4500); //waiting 3 seconds for sync between the UI and Push Notification

                            CloudManager cloudManager = new CloudManager();
                            cloudManager.Show();
                            cloudManager.Closed += (s, args) => this.Close();
                            this.Hide();

                            //cleaning up....
                            downloadTimer.Enabled = false;
                            download_pbar.Value = 0;
                            download_lbl.Text = "0.00";
                            bytesWrite = 0;
                            filesize = 0;
                        };
                        this.BeginInvoke(nextPage);
                    });
                    downloadThread.Start();
                }
                else
                {
                    CustomMessageBox msgBox = new CustomMessageBox();
                    msgBox.Show("Directory is invalid!");
                    path_txtbox.Text = "";
                }
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Not enough space on the drive!");
            }
            
        }
        private void paste_btn_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if(result == DialogResult.OK)
                    path_txtbox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void downloadTimer_Tick(object sender, EventArgs e)
        {
            int download_procent_pbar = (int)((float)bytesWrite / filesize * 100);
            float download_procent_lbl = (float)bytesWrite / filesize * 100;
            download_pbar.Value = download_procent_pbar;
            download_lbl.Text = download_procent_lbl.ToString("0.00") + "%";
        }
    }
}