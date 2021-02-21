using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
            welcome_lbl.Text = "Hi, " + Client.username + "! Select your option.";
        }

        private void store_btn_Click(object sender, EventArgs e)
        {
            StoreDataWindow storeDataWindow = new StoreDataWindow();
            storeDataWindow.Show();
            this.Hide();
            storeDataWindow.Closed += (s, args) => this.Close();
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            DownloadWindow downloadWindow = new DownloadWindow();
            downloadWindow.Show();
            downloadWindow.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void CloudManager_btn_Click(object sender, EventArgs e)
        {
            CloudManager cloudManager = new CloudManager();
            cloudManager.Show();
            this.Hide();
            cloudManager.Closed += (s, args) => this.Close();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            OptionHelpForm optionHelpForm = new OptionHelpForm();
            optionHelpForm.Show();
            optionHelpForm.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void save_exit_btn_Click(object sender, EventArgs e)
        {
            //TODO: Saving the files based on server hard disk size management # Making an archive (.zip) of all files on save

            Client.disconnect();
            Application.Exit();
        }

        private void logout_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client.logout();

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            splashScreen.Closed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
