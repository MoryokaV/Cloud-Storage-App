// -- Code by Vlaviano -- //

using System;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class LoadingScreen : Form
    {
        public static long filesize = 0;
        public static long bytesWrite = 0;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            int percentage = Convert.ToInt32((float)bytesWrite/filesize * 100);
            pbar.Value = percentage;
            if (percentage == 100)
            {
                loadingTimer.Enabled = false;
                this.Close();
            }
        }
    }
}
