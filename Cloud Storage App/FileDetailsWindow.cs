using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class FileDetailsWindow : Form
    {
        public static string filename = "";
        public static string filetype = "";
        public static string filesize = "";
        public static string date_time = "";

        public FileDetailsWindow()
        {
            InitializeComponent();

            filename_lbl.Text = filename;
            if (filename_lbl.Text.Length <= 21) filename_lbl.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            else if (filename_lbl.Text.Length <= 24 && filename_lbl.Text.Length > 21) filename_lbl.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            else if (filename_lbl.Text.Length <= 31 && filename_lbl.Text.Length > 24) filename_lbl.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            else if(filename_lbl.Text.Length > 31) filename_lbl.Font = new Font("Century Gothic", 8, FontStyle.Bold);

            create_lbl.Text = "Created: " + date_time;

            filesize_lbl.Text = ((float)Client.getDownloadFileSize(filename + "." + filetype) / (1024 * 1024) > 1024) ? "Filesize: " + ((float)Client.getDownloadFileSize(filename + "." + filetype) / (1024 * 1024 * 1024)).ToString("0.00") + " GB" : "Filesize: " + ((float)Client.getDownloadFileSize(filename + "." + filetype) / (1024 * 1024)).ToString("0.00") + " MB";

            filetype_lbl.Text = "File type: ." + filetype;

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
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            CloudManager cloudManager = new CloudManager();
            cloudManager.Show();
            cloudManager.Closed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
