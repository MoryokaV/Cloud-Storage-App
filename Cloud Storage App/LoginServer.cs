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
    public partial class LoginServer : Form
    {
        public LoginServer()
        {
            InitializeComponent();
            pass_box.PasswordChar = '*';
        }

        private void server_btn_Click(object sender, EventArgs e)
        {
            if(usr_box.Text == "admin" && pass_box.Text == "admin")
            {
                var server = new Server();
                server.getIp();
                server.createServerAsync();
                ServerWindow serverWindow = new ServerWindow();
                serverWindow.Show();
                serverWindow.Closed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Access denied!");
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                startWindow.Closed += (s, args) => this.Close();
                this.Hide();
            }
        }
    }
}
