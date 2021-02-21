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
    public partial class OptionHelpForm : Form
    {
        public OptionHelpForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainWindow = new MainMenu();
            mainWindow.Show();
            mainWindow.Closed += (s, args) => this.Close();
            this.Hide();        
        }

        private void credits_btn_Click(object sender, EventArgs e)
        {
            CreditsWindow creditsWindow = new CreditsWindow();
            creditsWindow.Show();
            creditsWindow.Closed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
