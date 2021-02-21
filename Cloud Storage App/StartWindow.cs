// -- Code by Vlaviano -- //

using System;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            var client = new Client();
            client.connectToServer(); //non-static method

            if (Client.rememberMeCheck())
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                mainMenu.Closed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                LogInForm log = new LogInForm();
                log.Show();
                log.Closed += (s, args) => this.Close();
                this.Hide();
            }
        }
        private void server_btn_Click(object sender, EventArgs e)
        {
            LoginServer loginServer = new LoginServer();
            loginServer.Show();
            loginServer.Closed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
