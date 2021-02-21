// -- Code by Vlaviano -- //

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class ServerWindow : Form
    {
        public static String ip;
        public static int clients;
        
        //Setting the CPU & RAM Memory Usage Monitor 
        public PerformanceCounter CPU_Monitor = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        Process process = Process.GetCurrentProcess();

        //Seting a network Monitor for Send & Receive
        public static PerformanceCounterCategory pcg = new PerformanceCounterCategory("Network Interface");
        public static string instance = pcg.GetInstanceNames()[0];
        public PerformanceCounter Netowrk_Send_Monitor = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
        public PerformanceCounter Netowrk_Receive_Monitor = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);
        public float Netowrk_Send_Usage;
        public float Netowrk_Receive_Usage;

        //animation

        public bool direction = true;


        public ServerWindow()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ip_check.Checked)                
                ip_label.Text = "Server's IP:" + ip;
            else
                ip_label.Text = "Server's IP:---.---.-.---";
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            clients_lbl.Text = "Clients Connected: " + Server.clientsConnected.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Server.serverSocket.Stop();
            Application.Exit();
        }

        private void HardwareMonitorTimer_Tick(object sender, EventArgs e)
        {
            //Getting the Values & Variables
            float RAM_Usage = process.PrivateMemorySize64 / (1024 * 1024);
            float CPU_Usage = CPU_Monitor.NextValue();
            Netowrk_Send_Usage = Netowrk_Send_Monitor.NextValue();
            Netowrk_Receive_Usage = Netowrk_Receive_Monitor.NextValue();

            //Checking for the label size
            if(network_lbl.Text.Length > 43 && network_lbl.Text.Length < 46)
                network_lbl.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            else if (network_lbl.Text.Length >= 46)
                network_lbl.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            else
                network_lbl.Font = new Font("Century Gothic", 11, FontStyle.Bold);

            //Changing the UI every time the timer ticks!
            network_lbl.Text = "Network - Send: " + (Netowrk_Send_Usage / 1024).ToString("0.00") + " KB - Receive: " + (Netowrk_Receive_Usage / 1024).ToString("0.00") + " KB";
            cpu_lbl.Text = "CPU Usage: " + (int)CPU_Usage + "%";
            memory_lbl.Text = "RAM Usage: " + RAM_Usage + "MB";
        }

        public void fileAnimation()
        {
            int speed = 12;
             // true : go | false: return
            if (Netowrk_Send_Usage + Netowrk_Receive_Usage > 1024)
            {
                file.Visible = true;

                if (file.Location.X == 512)
                    direction = false;
                if (file.Location.X == 368)
                    direction = true;

                //max: 144 | 368 - 512
                if(direction == true)
                    file.Location = new Point(file.Location.X + speed, file.Location.Y);
                else
                    file.Location = new Point(file.Location.X - speed, file.Location.Y);
            }
            else
            {
                file.Location = new Point(368, file.Location.Y);
                file.Visible = false;
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            fileAnimation();
        }
    }
}
