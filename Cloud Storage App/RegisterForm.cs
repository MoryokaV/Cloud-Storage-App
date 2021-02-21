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
    public partial class RegisterForm : Form
    {

        public static string status;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pass_box_OnValueChanged(object sender, EventArgs e)
        {
            pass_box.isPassword = true;
        }

        private void conf_box_OnValueChanged(object sender, EventArgs e)
        {
            conf_box.isPassword = true;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            
            if(pass_box.Text.Length >= 4 && usr_box.Text.Length >= 4 )
            {
                if (usr_box.Text.Length < 25)
                {
                    if (conf_box.Text == pass_box.Text)
                    {
                        Client.register(usr_box.Text, pass_box.Text); //args: username & password

                        CustomMessageBox msgBox = new CustomMessageBox();
                        msgBox.Show(status);
                        if (status == "Account was created Succesfully!")
                        {
                            MainMenu chooseWindow = new MainMenu();
                            chooseWindow.Show();
                            chooseWindow.Closed += (s, args) => this.Close();
                            this.Hide();
                        }
                        else
                        {
                            usr_box.Text = "";
                            conf_box.Text = "";
                            pass_box.Text = "";
                        }

                    }
                    else
                    {
                        CustomMessageBox msgbox = new CustomMessageBox();
                        msgbox.Show("Password doesn't match!");
                        conf_box.Text = "";
                        pass_box.Text = "";
                    }
                }
                else
                {
                    CustomMessageBox msgBox = new CustomMessageBox();
                    msgBox.Show("Username must be maximum 25 characters long!");
                    usr_box.Text = "";
                    conf_box.Text = "";
                    pass_box.Text = "";
                }
                
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Username & Password must be at least 4 characters!");
                usr_box.Text = "";
                conf_box.Text = "";
                pass_box.Text = "";
            }           
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
            loginForm.Closed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
