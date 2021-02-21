using System;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class LogInForm : Form
    {
        public static string status;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            regForm.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void pass_box_OnValueChanged(object sender, EventArgs e)
        {
            pass_box.isPassword = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Client.disconnect();
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            startWindow.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            if(usr_box.Text.Length >= 4 || pass_box.Text.Length >= 4)
            {
                Client.logIn(usr_box.Text, pass_box.Text, remember.Checked);//args: username & password & rememberMe

                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show(status);
                if (status == "Login Succesfully!")
                {
                    MainMenu chooseWindow = new MainMenu();
                    chooseWindow.Show();
                    chooseWindow.Closed += (s, args) => this.Close();
                    this.Hide();
                }
                else
                {
                    pass_box.Text = "";
                    usr_box.Text = "";
                }                          
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Username and Password must be at least 4 characters!");
                pass_box.Text = "";
                usr_box.Text = "";
            }
        }
    }
}
