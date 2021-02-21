// -- Code by Vlaviano -- //

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.IO;

namespace Cloud_Storage_App
{
    public partial class CloudManager : Form
    {
        public static string[] files = new string[]{""};
        public static string status = "";


        public static long cloudSize;
        public CloudManager()
        {
            InitializeComponent();

            Client.getDirectorySize();

            //Setting the progress bar value using an algorith by Vlaviano Mario
            int procent_int = Convert.ToInt32((float)cloudSize / Client.cloudMaxSize * 100);
            float procent_float = (float)cloudSize / Client.cloudMaxSize * 100;
            pbar.Value = procent_int;
            procent_lbl.Text = procent_float.ToString("0.00") + "%";
            space_txt.Text = "Storage Available: " + ((float)cloudSize / 1024 / 1024 / 1024).ToString("0.00") + "GB / " + ((float)Client.cloudMaxSize / 1024 / 1024 / 1024).ToString("0.00") + "GB";


            //Adding file names in comboBox
            Client.getStoredFilenames();
            foreach (string file in files)
                file_combo.Items.Add(file);
            if (file_combo.Items.Count == 0) file_combo.Text = " - - - It look like your cloud is empty! - - - ";
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

            if(file_combo.Text != "  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " && file_combo.Text != " - - - It look like your cloud is empty! - - - ")
            {
                open_btn.Visible = true;
                details_btn.Visible = true;
                delete_btn.Visible = true;
            }
            else
            {
                open_btn.Visible = false;
                details_btn.Visible = false;
                delete_btn.Visible = false;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Moving to Trash - - - - - - - - - - - - - - - - - -
            Client.deleteFile(file_combo.Text);

            //Resetting the GUI
            fileType_ic.Image = new Bitmap(Properties.Resources.unknownFile_ic);
            files = files.Where(val => val != file_combo.Text).ToArray();
            file_combo.Items.Remove(file_combo.Text);

            //Displaying a msg
            CustomMessageBox msgBox = new CustomMessageBox();
            msgBox.Show(status);

            delete_btn.Visible = false;
            open_btn.Visible = false;
            details_btn.Visible = false;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            string filename = file_combo.Text;

            if (Client.diskSpaceAvailability(filename, Directory.GetCurrentDirectory(), Client.getDownloadFileSize(filename)))
            {
                LoadingScreen.filesize = Client.getDownloadFileSize(filename);

                Thread previewThread = new Thread(() => {
                    Action nextPage = () =>
                    {
                        LoadingScreen loadingScreen = new LoadingScreen();
                        loadingScreen.Show();
                    };
                    this.BeginInvoke(nextPage);

                    Client.previewFile(filename);
                });
                previewThread.Start();
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Not enough space on drive to preview!");
            }
        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            Client.fileDetails(file_combo.Text);

            //opening the specific window to view the values generated in the previous Client.method()
            FileDetailsWindow fileDetailsWindow = new FileDetailsWindow();
            fileDetailsWindow.Show();
            fileDetailsWindow.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            sidePanel.Visible = false;
            sidePanel.Width = 0;
            slide_animation.ShowSync(sidePanel);
            menu_btn.Visible = false;
            menu_btn2.Visible = true;
        }

        private void menu_btn2_Click(object sender, EventArgs e)
        {
            sidePanel.Visible = false;
            sidePanel.Width = 280;
            tableLayoutSidePanel.Width = 280;
            slide_animation.ShowSync(sidePanel);
            menu_btn2.Visible = false;
            menu_btn.Visible = true;

            tableLayoutSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            //SlideMenu Labels
            usr_lbl.Text = Client.username;
            cloudSize_lbl.Text = "Storage Size: " + ((float)Client.cloudMaxSize/1024/1024/1024).ToString("0.00") + "GB";
            files_lbl.Text = "Files Stored: " + files.Length.ToString();
            accType_lbl.Text = "Account Type: " + Client.accountType;
            trash_lbl.Text = "Trash Size: " + ((float)Client.trashSize / 1024 / 1024).ToString("0.00") + "MB";
        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/developer?id=VMA+Software");
            //Sending a link and adding 1.00GB to the maximum storage space
            Client.upgradeAccount();

            //Disposing the side menu
            sidePanel.Visible = false;
            sidePanel.Width = 0;
            slide_animation.ShowSync(sidePanel);
            menu_btn.Visible = false;
            menu_btn2.Visible = true;

            Client.getDirectorySize();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainWindow = new MainMenu();
            mainWindow.Show();
            mainWindow.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void trash_btn_Click(object sender, EventArgs e)
        {
            if(Client.getTrashSize() > 0)
            {
                TrashForm trashForm = new TrashForm();
                trashForm.Show();
                trashForm.Closed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Trash Bin is Empty! :)");

                sidePanel.Visible = false;
                sidePanel.Width = 0;
                slide_animation.ShowSync(sidePanel);
                menu_btn.Visible = false;
                menu_btn2.Visible = true;
            }
        }
    }
}
