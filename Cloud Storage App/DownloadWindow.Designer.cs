namespace Cloud_Storage_App
{
    partial class DownloadWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.download_lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.download_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.download_pbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.fileType_ic = new System.Windows.Forms.PictureBox();
            this.info_lbl = new System.Windows.Forms.Label();
            this.file_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.path_txtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.paste_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.downloadTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteFileCheckBox = new System.Windows.Forms.CheckBox();
            this.filesize_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.download_btn = new ePOSOne.btnProduct.Button_WOC();
            this.back_btn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.fileType_ic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(907, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download your stored files!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // download_lbl2
            // 
            this.download_lbl2.AutoSize = true;
            this.download_lbl2.BackColor = System.Drawing.Color.Transparent;
            this.download_lbl2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_lbl2.ForeColor = System.Drawing.Color.White;
            this.download_lbl2.Location = new System.Drawing.Point(48, 458);
            this.download_lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.download_lbl2.Name = "download_lbl2";
            this.download_lbl2.Size = new System.Drawing.Size(167, 45);
            this.download_lbl2.TabIndex = 28;
            this.download_lbl2.Text = "Downloading...";
            this.download_lbl2.Visible = false;
            // 
            // download_lbl
            // 
            this.download_lbl.AutoSize = true;
            this.download_lbl.BackColor = System.Drawing.Color.Transparent;
            this.download_lbl.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_lbl.ForeColor = System.Drawing.Color.White;
            this.download_lbl.Location = new System.Drawing.Point(713, 463);
            this.download_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.download_lbl.Name = "download_lbl";
            this.download_lbl.Size = new System.Drawing.Size(83, 38);
            this.download_lbl.TabIndex = 27;
            this.download_lbl.Text = "100.00%";
            this.download_lbl.Visible = false;
            // 
            // download_pbar
            // 
            this.download_pbar.BackColor = System.Drawing.Color.Silver;
            this.download_pbar.BorderRadius = 5;
            this.download_pbar.Location = new System.Drawing.Point(239, 463);
            this.download_pbar.Margin = new System.Windows.Forms.Padding(5);
            this.download_pbar.MaximumValue = 100;
            this.download_pbar.Name = "download_pbar";
            this.download_pbar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.download_pbar.Size = new System.Drawing.Size(467, 26);
            this.download_pbar.TabIndex = 26;
            this.download_pbar.Value = 0;
            this.download_pbar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(777, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "code by Vlaviano";
            // 
            // fileType_ic
            // 
            this.fileType_ic.BackColor = System.Drawing.Color.Transparent;
            this.fileType_ic.Image = global::Cloud_Storage_App.Properties.Resources.unknownFile_ic;
            this.fileType_ic.InitialImage = null;
            this.fileType_ic.Location = new System.Drawing.Point(380, 113);
            this.fileType_ic.Margin = new System.Windows.Forms.Padding(4);
            this.fileType_ic.Name = "fileType_ic";
            this.fileType_ic.Size = new System.Drawing.Size(51, 43);
            this.fileType_ic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileType_ic.TabIndex = 32;
            this.fileType_ic.TabStop = false;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.Transparent;
            this.info_lbl.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.info_lbl.Location = new System.Drawing.Point(16, 122);
            this.info_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(337, 27);
            this.info_lbl.TabIndex = 31;
            this.info_lbl.Text = "Select your file to download:";
            // 
            // file_combo
            // 
            this.file_combo.BackColor = System.Drawing.Color.SlateGray;
            this.file_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.file_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_combo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.file_combo.FormattingEnabled = true;
            this.file_combo.Location = new System.Drawing.Point(445, 118);
            this.file_combo.Margin = new System.Windows.Forms.Padding(4);
            this.file_combo.Name = "file_combo";
            this.file_combo.Size = new System.Drawing.Size(476, 32);
            this.file_combo.TabIndex = 30;
            this.file_combo.TabStop = false;
            this.file_combo.SelectedIndexChanged += new System.EventHandler(this.file_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Output folder path:";
            // 
            // path_txtbox
            // 
            this.path_txtbox.BackColor = System.Drawing.Color.Gainsboro;
            this.path_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.path_txtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.path_txtbox.HintForeColor = System.Drawing.Color.Empty;
            this.path_txtbox.HintText = "C:\\Users\\admin\\Desktop\\";
            this.path_txtbox.isPassword = false;
            this.path_txtbox.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.path_txtbox.LineIdleColor = System.Drawing.Color.SlateGray;
            this.path_txtbox.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.path_txtbox.LineThickness = 3;
            this.path_txtbox.Location = new System.Drawing.Point(288, 188);
            this.path_txtbox.Margin = new System.Windows.Forms.Padding(5);
            this.path_txtbox.Name = "path_txtbox";
            this.path_txtbox.Size = new System.Drawing.Size(512, 42);
            this.path_txtbox.TabIndex = 35;
            this.path_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(181, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 38;
            // 
            // paste_btn
            // 
            this.paste_btn.Activecolor = System.Drawing.Color.LightSlateGray;
            this.paste_btn.BackColor = System.Drawing.Color.SlateGray;
            this.paste_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paste_btn.BorderRadius = 0;
            this.paste_btn.ButtonText = "Browse";
            this.paste_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paste_btn.DisabledColor = System.Drawing.Color.Gray;
            this.paste_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.paste_btn.Iconimage = null;
            this.paste_btn.Iconimage_right = null;
            this.paste_btn.Iconimage_right_Selected = null;
            this.paste_btn.Iconimage_Selected = null;
            this.paste_btn.IconMarginLeft = 0;
            this.paste_btn.IconMarginRight = 0;
            this.paste_btn.IconRightVisible = true;
            this.paste_btn.IconRightZoom = 0D;
            this.paste_btn.IconVisible = true;
            this.paste_btn.IconZoom = 90D;
            this.paste_btn.IsTab = false;
            this.paste_btn.Location = new System.Drawing.Point(809, 188);
            this.paste_btn.Margin = new System.Windows.Forms.Padding(5);
            this.paste_btn.Name = "paste_btn";
            this.paste_btn.Normalcolor = System.Drawing.Color.SlateGray;
            this.paste_btn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.paste_btn.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.paste_btn.selected = false;
            this.paste_btn.Size = new System.Drawing.Size(115, 42);
            this.paste_btn.TabIndex = 41;
            this.paste_btn.Text = "Browse";
            this.paste_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paste_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.paste_btn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paste_btn.Click += new System.EventHandler(this.paste_btn_Click_1);
            // 
            // downloadTimer
            // 
            this.downloadTimer.Interval = 5;
            this.downloadTimer.Tick += new System.EventHandler(this.downloadTimer_Tick);
            // 
            // deleteFileCheckBox
            // 
            this.deleteFileCheckBox.AutoSize = true;
            this.deleteFileCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.deleteFileCheckBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFileCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteFileCheckBox.Location = new System.Drawing.Point(272, 254);
            this.deleteFileCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteFileCheckBox.Name = "deleteFileCheckBox";
            this.deleteFileCheckBox.Size = new System.Drawing.Size(372, 33);
            this.deleteFileCheckBox.TabIndex = 42;
            this.deleteFileCheckBox.Text = "Delete file after download ?";
            this.deleteFileCheckBox.UseVisualStyleBackColor = false;
            // 
            // filesize_lbl
            // 
            this.filesize_lbl.BackColor = System.Drawing.Color.Transparent;
            this.filesize_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesize_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.filesize_lbl.Location = new System.Drawing.Point(756, 154);
            this.filesize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesize_lbl.Name = "filesize_lbl";
            this.filesize_lbl.Size = new System.Drawing.Size(167, 28);
            this.filesize_lbl.TabIndex = 43;
            this.filesize_lbl.Text = "File size: - MB";
            this.filesize_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // download_btn
            // 
            this.download_btn.BackColor = System.Drawing.Color.Transparent;
            this.download_btn.BorderColor = System.Drawing.Color.Transparent;
            this.download_btn.ButtonColor = System.Drawing.Color.White;
            this.download_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.download_btn.FlatAppearance.BorderSize = 0;
            this.download_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.download_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_btn.Location = new System.Drawing.Point(345, 361);
            this.download_btn.Margin = new System.Windows.Forms.Padding(4);
            this.download_btn.Name = "download_btn";
            this.download_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.download_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.download_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.download_btn.Size = new System.Drawing.Size(253, 49);
            this.download_btn.TabIndex = 25;
            this.download_btn.Text = "Download File!";
            this.download_btn.TextColor = System.Drawing.Color.Maroon;
            this.download_btn.UseVisualStyleBackColor = false;
            this.download_btn.Visible = false;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BorderColor = System.Drawing.Color.Transparent;
            this.back_btn.ButtonColor = System.Drawing.Color.Gainsboro;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(16, 11);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.back_btn.Size = new System.Drawing.Size(92, 31);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "← Back";
            this.back_btn.TextColor = System.Drawing.Color.Maroon;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // DownloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.filesize_lbl);
            this.Controls.Add(this.deleteFileCheckBox);
            this.Controls.Add(this.paste_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.path_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileType_ic);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.file_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.download_lbl2);
            this.Controls.Add(this.download_lbl);
            this.Controls.Add(this.download_pbar);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DownloadWindow";
            this.Text = "Cloud Storage App";
            ((System.ComponentModel.ISupportInitialize)(this.fileType_ic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC back_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel download_lbl2;
        private Bunifu.Framework.UI.BunifuCustomLabel download_lbl;
        private Bunifu.Framework.UI.BunifuProgressBar download_pbar;
        private ePOSOne.btnProduct.Button_WOC download_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fileType_ic;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.ComboBox file_combo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox path_txtbox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton paste_btn;
        private System.Windows.Forms.Timer downloadTimer;
        private System.Windows.Forms.CheckBox deleteFileCheckBox;
        private Bunifu.Framework.UI.BunifuCustomLabel filesize_lbl;
    }
}