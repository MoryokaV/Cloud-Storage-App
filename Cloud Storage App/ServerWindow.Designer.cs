namespace Cloud_Storage_App
{
    partial class ServerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerWindow));
            this.ip_label = new System.Windows.Forms.Label();
            this.ip_check = new System.Windows.Forms.CheckBox();
            this.clients_lbl = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.close_btn = new ePOSOne.btnProduct.Button_WOC();
            this.HardwareMonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.cpu_lbl = new System.Windows.Forms.Label();
            this.memory_lbl = new System.Windows.Forms.Label();
            this.network_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.stats_lbl = new System.Windows.Forms.Label();
            this.folder1 = new System.Windows.Forms.PictureBox();
            this.folder2 = new System.Windows.Forms.PictureBox();
            this.file = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            this.SuspendLayout();
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.BackColor = System.Drawing.Color.Transparent;
            this.ip_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_label.ForeColor = System.Drawing.Color.Black;
            this.ip_label.Location = new System.Drawing.Point(16, 9);
            this.ip_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(295, 32);
            this.ip_label.TabIndex = 0;
            this.ip_label.Text = "Server\'s IP: ---.---.-.---";
            // 
            // ip_check
            // 
            this.ip_check.AutoSize = true;
            this.ip_check.BackColor = System.Drawing.Color.Transparent;
            this.ip_check.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_check.ForeColor = System.Drawing.Color.Black;
            this.ip_check.Location = new System.Drawing.Point(369, 9);
            this.ip_check.Margin = new System.Windows.Forms.Padding(4);
            this.ip_check.Name = "ip_check";
            this.ip_check.Size = new System.Drawing.Size(106, 27);
            this.ip_check.TabIndex = 1;
            this.ip_check.Text = "Show IP";
            this.ip_check.UseVisualStyleBackColor = false;
            this.ip_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clients_lbl
            // 
            this.clients_lbl.AutoSize = true;
            this.clients_lbl.BackColor = System.Drawing.Color.Transparent;
            this.clients_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_lbl.ForeColor = System.Drawing.Color.Black;
            this.clients_lbl.Location = new System.Drawing.Point(16, 50);
            this.clients_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clients_lbl.Name = "clients_lbl";
            this.clients_lbl.Size = new System.Drawing.Size(287, 32);
            this.clients_lbl.TabIndex = 2;
            this.clients_lbl.Text = "Clients Connected: 0";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Green;
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(339, 50);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(147, 34);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Tag = " ";
            this.refresh_btn.Text = "Refresh ↺";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BorderColor = System.Drawing.Color.Transparent;
            this.close_btn.ButtonColor = System.Drawing.Color.White;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(16, 480);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.close_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.close_btn.Size = new System.Drawing.Size(907, 48);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "Close Server";
            this.close_btn.TextColor = System.Drawing.Color.Maroon;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // HardwareMonitorTimer
            // 
            this.HardwareMonitorTimer.Enabled = true;
            this.HardwareMonitorTimer.Interval = 500;
            this.HardwareMonitorTimer.Tick += new System.EventHandler(this.HardwareMonitorTimer_Tick);
            // 
            // cpu_lbl
            // 
            this.cpu_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cpu_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cpu_lbl.Location = new System.Drawing.Point(261, 320);
            this.cpu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpu_lbl.Name = "cpu_lbl";
            this.cpu_lbl.Size = new System.Drawing.Size(416, 34);
            this.cpu_lbl.TabIndex = 12;
            this.cpu_lbl.Text = "CPU Usage: ";
            this.cpu_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memory_lbl
            // 
            this.memory_lbl.BackColor = System.Drawing.Color.Transparent;
            this.memory_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memory_lbl.Location = new System.Drawing.Point(264, 368);
            this.memory_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memory_lbl.Name = "memory_lbl";
            this.memory_lbl.Size = new System.Drawing.Size(412, 27);
            this.memory_lbl.TabIndex = 13;
            this.memory_lbl.Text = "RAM Usage: ";
            this.memory_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // network_lbl
            // 
            this.network_lbl.BackColor = System.Drawing.Color.Transparent;
            this.network_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.network_lbl.Location = new System.Drawing.Point(260, 416);
            this.network_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.network_lbl.Name = "network_lbl";
            this.network_lbl.Size = new System.Drawing.Size(420, 22);
            this.network_lbl.TabIndex = 14;
            this.network_lbl.Text = "Network  - Send: 0.00 KB - Receive: 0.00 KB";
            this.network_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Cloud_Storage_App.Properties.Resources.frame;
            this.pictureBox1.Location = new System.Drawing.Point(229, 241);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cloud_Storage_App.Properties.Resources.cpu_ic_copy;
            this.pictureBox2.Location = new System.Drawing.Point(264, 261);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Cloud_Storage_App.Properties.Resources.mem_ic___copy;
            this.pictureBox3.Location = new System.Drawing.Point(616, 261);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // stats_lbl
            // 
            this.stats_lbl.BackColor = System.Drawing.Color.Transparent;
            this.stats_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.stats_lbl.Location = new System.Drawing.Point(261, 261);
            this.stats_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stats_lbl.Name = "stats_lbl";
            this.stats_lbl.Size = new System.Drawing.Size(416, 38);
            this.stats_lbl.TabIndex = 15;
            this.stats_lbl.Text = "● Hardware Monitor ●";
            this.stats_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folder1
            // 
            this.folder1.BackColor = System.Drawing.Color.Transparent;
            this.folder1.Image = global::Cloud_Storage_App.Properties.Resources.folder_ic_server;
            this.folder1.Location = new System.Drawing.Point(267, 113);
            this.folder1.Margin = new System.Windows.Forms.Padding(4);
            this.folder1.Name = "folder1";
            this.folder1.Size = new System.Drawing.Size(93, 86);
            this.folder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder1.TabIndex = 19;
            this.folder1.TabStop = false;
            // 
            // folder2
            // 
            this.folder2.BackColor = System.Drawing.Color.Transparent;
            this.folder2.Image = global::Cloud_Storage_App.Properties.Resources.folder_ic_client;
            this.folder2.Location = new System.Drawing.Point(587, 113);
            this.folder2.Margin = new System.Windows.Forms.Padding(4);
            this.folder2.Name = "folder2";
            this.folder2.Size = new System.Drawing.Size(93, 86);
            this.folder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder2.TabIndex = 20;
            this.folder2.TabStop = false;
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.Transparent;
            this.file.Image = global::Cloud_Storage_App.Properties.Resources.flyingFile_ic;
            this.file.Location = new System.Drawing.Point(368, 126);
            this.file.Margin = new System.Windows.Forms.Padding(4);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(67, 62);
            this.file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.file.TabIndex = 21;
            this.file.TabStop = false;
            this.file.Visible = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.log_reg_background_8K;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.file);
            this.Controls.Add(this.folder2);
            this.Controls.Add(this.folder1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.stats_lbl);
            this.Controls.Add(this.network_lbl);
            this.Controls.Add(this.memory_lbl);
            this.Controls.Add(this.cpu_lbl);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.clients_lbl);
            this.Controls.Add(this.ip_check);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ServerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Stoarage App (Server)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.CheckBox ip_check;
        private System.Windows.Forms.Label clients_lbl;
        private System.Windows.Forms.Button refresh_btn;
        private ePOSOne.btnProduct.Button_WOC close_btn;
        private System.Windows.Forms.Timer HardwareMonitorTimer;
        private System.Windows.Forms.Label cpu_lbl;
        private System.Windows.Forms.Label memory_lbl;
        private System.Windows.Forms.Label network_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label stats_lbl;
        private System.Windows.Forms.PictureBox folder1;
        private System.Windows.Forms.PictureBox folder2;
        private System.Windows.Forms.PictureBox file;
        private System.Windows.Forms.Timer animationTimer;
    }
}