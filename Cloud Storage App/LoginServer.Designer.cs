namespace Cloud_Storage_App
{
    partial class LoginServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginServer));
            this.usr_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.server_btn = new System.Windows.Forms.Button();
            this.background = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // usr_box
            // 
            this.usr_box.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_box.Location = new System.Drawing.Point(113, 34);
            this.usr_box.Margin = new System.Windows.Forms.Padding(4);
            this.usr_box.Name = "usr_box";
            this.usr_box.Size = new System.Drawing.Size(248, 24);
            this.usr_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(113, 66);
            this.pass_box.Margin = new System.Windows.Forms.Padding(4);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(248, 26);
            this.pass_box.TabIndex = 2;
            // 
            // server_btn
            // 
            this.server_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.server_btn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_btn.ForeColor = System.Drawing.Color.White;
            this.server_btn.Location = new System.Drawing.Point(20, 119);
            this.server_btn.Margin = new System.Windows.Forms.Padding(4);
            this.server_btn.Name = "server_btn";
            this.server_btn.Size = new System.Drawing.Size(343, 36);
            this.server_btn.TabIndex = 4;
            this.server_btn.Text = "Start Server";
            this.server_btn.UseVisualStyleBackColor = false;
            this.server_btn.Click += new System.EventHandler(this.server_btn_Click);
            // 
            // background
            // 
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.label2);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.GradientBottomLeft = System.Drawing.Color.PapayaWhip;
            this.background.GradientBottomRight = System.Drawing.Color.Khaki;
            this.background.GradientTopLeft = System.Drawing.Color.DarkGoldenrod;
            this.background.GradientTopRight = System.Drawing.Color.PaleGoldenrod;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Quality = 10;
            this.background.Size = new System.Drawing.Size(379, 170);
            this.background.TabIndex = 5;
            // 
            // LoginServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(379, 170);
            this.Controls.Add(this.server_btn);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.usr_box);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Server";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usr_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button server_btn;
        private Bunifu.Framework.UI.BunifuGradientPanel background;
    }
}