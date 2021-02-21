using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class CreditsWindow : Form
    {
        public CreditsWindow()
        {
            InitializeComponent();
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/mario.vlaviano.75");
        }
        private void googlePlay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/developer?id=VMA+Software");
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            mainMenu.Closed += (s, args) => this.Hide();
            this.Hide();
        }

        private void olx_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.olx.ro/oferte/user/ooKd6/");
        }
    }
}
