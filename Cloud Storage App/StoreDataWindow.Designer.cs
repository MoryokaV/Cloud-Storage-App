namespace Cloud_Storage_App
{
    partial class StoreDataWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreDataWindow));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.path_txtbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.browse_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.space_txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.procent_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.upload_pbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.upload_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.upload_lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.uploadTimer = new System.Windows.Forms.Timer(this.components);
            this.filesize_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.back_btn = new ePOSOne.btnProduct.Button_WOC();
            this.upload_btn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(281, 37);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(360, 62);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Store files secure and fast!";
            // 
            // path_txtbox
            // 
            this.path_txtbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.path_txtbox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_txtbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.path_txtbox.Location = new System.Drawing.Point(217, 171);
            this.path_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.path_txtbox.Name = "path_txtbox";
            this.path_txtbox.Size = new System.Drawing.Size(705, 35);
            this.path_txtbox.TabIndex = 14;
            // 
            // browse_btn
            // 
            this.browse_btn.Activecolor = System.Drawing.Color.Silver;
            this.browse_btn.BackColor = System.Drawing.Color.Silver;
            this.browse_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse_btn.BorderRadius = 0;
            this.browse_btn.ButtonText = "Browse →";
            this.browse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse_btn.DisabledColor = System.Drawing.Color.Gray;
            this.browse_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.browse_btn.Iconimage = null;
            this.browse_btn.Iconimage_right = null;
            this.browse_btn.Iconimage_right_Selected = null;
            this.browse_btn.Iconimage_Selected = null;
            this.browse_btn.IconMarginLeft = 0;
            this.browse_btn.IconMarginRight = 0;
            this.browse_btn.IconRightVisible = true;
            this.browse_btn.IconRightZoom = 0D;
            this.browse_btn.IconVisible = true;
            this.browse_btn.IconZoom = 70D;
            this.browse_btn.IsTab = false;
            this.browse_btn.Location = new System.Drawing.Point(75, 171);
            this.browse_btn.Margin = new System.Windows.Forms.Padding(5);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Normalcolor = System.Drawing.Color.Silver;
            this.browse_btn.OnHovercolor = System.Drawing.Color.Silver;
            this.browse_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.browse_btn.selected = false;
            this.browse_btn.Size = new System.Drawing.Size(134, 37);
            this.browse_btn.TabIndex = 15;
            this.browse_btn.Text = "Browse →";
            this.browse_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browse_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.browse_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(779, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "code by Vlaviano";
            // 
            // pbar
            // 
            this.pbar.BackColor = System.Drawing.Color.Silver;
            this.pbar.BorderRadius = 5;
            this.pbar.Location = new System.Drawing.Point(385, 254);
            this.pbar.Margin = new System.Windows.Forms.Padding(5);
            this.pbar.MaximumValue = 100;
            this.pbar.Name = "pbar";
            this.pbar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.pbar.Size = new System.Drawing.Size(467, 18);
            this.pbar.TabIndex = 17;
            this.pbar.Value = 0;
            // 
            // space_txt
            // 
            this.space_txt.AutoSize = true;
            this.space_txt.BackColor = System.Drawing.Color.Transparent;
            this.space_txt.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space_txt.ForeColor = System.Drawing.Color.White;
            this.space_txt.Location = new System.Drawing.Point(8, 242);
            this.space_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.space_txt.Name = "space_txt";
            this.space_txt.Size = new System.Drawing.Size(349, 45);
            this.space_txt.TabIndex = 18;
            this.space_txt.Text = "Storage Available: 0.00GB / 16.00GB";
            // 
            // procent_lbl
            // 
            this.procent_lbl.AutoSize = true;
            this.procent_lbl.BackColor = System.Drawing.Color.Transparent;
            this.procent_lbl.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procent_lbl.ForeColor = System.Drawing.Color.White;
            this.procent_lbl.Location = new System.Drawing.Point(860, 247);
            this.procent_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.procent_lbl.Name = "procent_lbl";
            this.procent_lbl.Size = new System.Drawing.Size(83, 38);
            this.procent_lbl.TabIndex = 21;
            this.procent_lbl.Text = "100.00%";
            // 
            // upload_pbar
            // 
            this.upload_pbar.BackColor = System.Drawing.Color.Silver;
            this.upload_pbar.BorderRadius = 5;
            this.upload_pbar.Location = new System.Drawing.Point(228, 406);
            this.upload_pbar.Margin = new System.Windows.Forms.Padding(5);
            this.upload_pbar.MaximumValue = 100;
            this.upload_pbar.Name = "upload_pbar";
            this.upload_pbar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.upload_pbar.Size = new System.Drawing.Size(467, 26);
            this.upload_pbar.TabIndex = 22;
            this.upload_pbar.Value = 0;
            this.upload_pbar.Visible = false;
            // 
            // upload_lbl
            // 
            this.upload_lbl.AutoSize = true;
            this.upload_lbl.BackColor = System.Drawing.Color.Transparent;
            this.upload_lbl.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_lbl.ForeColor = System.Drawing.Color.White;
            this.upload_lbl.Location = new System.Drawing.Point(703, 402);
            this.upload_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upload_lbl.Name = "upload_lbl";
            this.upload_lbl.Size = new System.Drawing.Size(83, 38);
            this.upload_lbl.TabIndex = 23;
            this.upload_lbl.Text = "100.00%";
            this.upload_lbl.Visible = false;
            // 
            // upload_lbl2
            // 
            this.upload_lbl2.AutoSize = true;
            this.upload_lbl2.BackColor = System.Drawing.Color.Transparent;
            this.upload_lbl2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_lbl2.ForeColor = System.Drawing.Color.White;
            this.upload_lbl2.Location = new System.Drawing.Point(67, 398);
            this.upload_lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upload_lbl2.Name = "upload_lbl2";
            this.upload_lbl2.Size = new System.Drawing.Size(140, 45);
            this.upload_lbl2.TabIndex = 24;
            this.upload_lbl2.Text = "Uploading...";
            this.upload_lbl2.Visible = false;
            // 
            // uploadTimer
            // 
            this.uploadTimer.Interval = 5;
            this.uploadTimer.Tick += new System.EventHandler(this.uploadTimer_Tick);
            // 
            // filesize_lbl
            // 
            this.filesize_lbl.BackColor = System.Drawing.Color.Transparent;
            this.filesize_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesize_lbl.ForeColor = System.Drawing.Color.White;
            this.filesize_lbl.Location = new System.Drawing.Point(627, 212);
            this.filesize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesize_lbl.Name = "filesize_lbl";
            this.filesize_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.filesize_lbl.Size = new System.Drawing.Size(295, 35);
            this.filesize_lbl.TabIndex = 25;
            this.filesize_lbl.Text = "- MB Filesize";
            this.filesize_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BorderColor = System.Drawing.Color.Transparent;
            this.back_btn.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(16, 15);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.back_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.back_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.back_btn.Size = new System.Drawing.Size(88, 41);
            this.back_btn.TabIndex = 20;
            this.back_btn.Text = "← Back";
            this.back_btn.TextColor = System.Drawing.Color.Maroon;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // upload_btn
            // 
            this.upload_btn.BackColor = System.Drawing.Color.Transparent;
            this.upload_btn.BorderColor = System.Drawing.Color.Transparent;
            this.upload_btn.ButtonColor = System.Drawing.Color.White;
            this.upload_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.upload_btn.FlatAppearance.BorderSize = 0;
            this.upload_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.upload_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.Location = new System.Drawing.Point(335, 340);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(4);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.upload_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.upload_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.upload_btn.Size = new System.Drawing.Size(253, 49);
            this.upload_btn.TabIndex = 19;
            this.upload_btn.Text = "Upload Data";
            this.upload_btn.TextColor = System.Drawing.Color.Maroon;
            this.upload_btn.UseVisualStyleBackColor = false;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.browseDialog_ic;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 59);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // StoreDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filesize_lbl);
            this.Controls.Add(this.upload_lbl2);
            this.Controls.Add(this.upload_lbl);
            this.Controls.Add(this.upload_pbar);
            this.Controls.Add(this.procent_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.space_txt);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.path_txtbox);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StoreDataWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Storage App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox path_txtbox;
        private Bunifu.Framework.UI.BunifuFlatButton browse_btn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuProgressBar pbar;
        private Bunifu.Framework.UI.BunifuCustomLabel space_txt;
        private ePOSOne.btnProduct.Button_WOC upload_btn;
        private ePOSOne.btnProduct.Button_WOC back_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel procent_lbl;
        private Bunifu.Framework.UI.BunifuProgressBar upload_pbar;
        private Bunifu.Framework.UI.BunifuCustomLabel upload_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel upload_lbl2;
        private System.Windows.Forms.Timer uploadTimer;
        private Bunifu.Framework.UI.BunifuCustomLabel filesize_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}