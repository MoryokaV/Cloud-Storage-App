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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void wait_timer_Tick(object sender, EventArgs e)
        {
            pbar2.Width += 4;
            if(pbar2.Width >= 700)
            {
                wait_timer.Stop(); // Stop the timer if the pbar2 (panel) is full

                //Disposing the splash screen
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                this.Hide();
                startWindow.Closed += (s, args) => this.Close();
            }
        }
    }
}
