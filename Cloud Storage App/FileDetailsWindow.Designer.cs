namespace Cloud_Storage_App
{
    partial class FileDetailsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDetailsWindow));
            this.filename_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.create_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.filesize_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.filetype_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.close_btn = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filebackground = new System.Windows.Forms.Panel();
            this.fileType_ic = new System.Windows.Forms.PictureBox();
            this.tableLayout.SuspendLayout();
            this.filebackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileType_ic)).BeginInit();
            this.SuspendLayout();
            // 
            // filename_lbl
            // 
            this.filename_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filename_lbl.BackColor = System.Drawing.Color.Transparent;
            this.filename_lbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.filename_lbl.Location = new System.Drawing.Point(4, 193);
            this.filename_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filename_lbl.Name = "filename_lbl";
            this.filename_lbl.Size = new System.Drawing.Size(504, 73);
            this.filename_lbl.TabIndex = 4;
            this.filename_lbl.Text = "Documente";
            this.filename_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // create_lbl
            // 
            this.create_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_lbl.BackColor = System.Drawing.Color.Transparent;
            this.create_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_lbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.create_lbl.Location = new System.Drawing.Point(4, 266);
            this.create_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.create_lbl.Name = "create_lbl";
            this.create_lbl.Size = new System.Drawing.Size(504, 73);
            this.create_lbl.TabIndex = 5;
            this.create_lbl.Text = "Created:  21-03-2020 11:59";
            this.create_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filesize_lbl
            // 
            this.filesize_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesize_lbl.BackColor = System.Drawing.Color.Transparent;
            this.filesize_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesize_lbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.filesize_lbl.Location = new System.Drawing.Point(4, 339);
            this.filesize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesize_lbl.Name = "filesize_lbl";
            this.filesize_lbl.Size = new System.Drawing.Size(504, 73);
            this.filesize_lbl.TabIndex = 6;
            this.filesize_lbl.Text = "Filesize: 1023.00MB";
            this.filesize_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filetype_lbl
            // 
            this.filetype_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filetype_lbl.BackColor = System.Drawing.Color.Transparent;
            this.filetype_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filetype_lbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.filetype_lbl.Location = new System.Drawing.Point(4, 412);
            this.filetype_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filetype_lbl.Name = "filetype_lbl";
            this.filetype_lbl.Size = new System.Drawing.Size(504, 73);
            this.filetype_lbl.TabIndex = 7;
            this.filetype_lbl.Text = "File Type: .zip";
            this.filetype_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BorderColor = System.Drawing.Color.Transparent;
            this.close_btn.ButtonColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(19, 489);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverTextColor = System.Drawing.Color.Silver;
            this.close_btn.Size = new System.Drawing.Size(473, 31);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "Close ✖";
            this.close_btn.TextColor = System.Drawing.Color.Gainsboro;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "code by Vlaviano";
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.filebackground, 0, 1);
            this.tableLayout.Controls.Add(this.close_btn, 0, 6);
            this.tableLayout.Controls.Add(this.label2, 0, 0);
            this.tableLayout.Controls.Add(this.filetype_lbl, 0, 5);
            this.tableLayout.Controls.Add(this.filename_lbl, 0, 2);
            this.tableLayout.Controls.Add(this.filesize_lbl, 0, 4);
            this.tableLayout.Controls.Add(this.create_lbl, 0, 3);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 7;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.786291F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.25742F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0425F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0425F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0425F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0425F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.786291F));
            this.tableLayout.Size = new System.Drawing.Size(512, 524);
            this.tableLayout.TabIndex = 11;
            // 
            // filebackground
            // 
            this.filebackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filebackground.BackColor = System.Drawing.Color.Transparent;
            this.filebackground.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.round_rect_white;
            this.filebackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filebackground.Controls.Add(this.fileType_ic);
            this.filebackground.Location = new System.Drawing.Point(171, 38);
            this.filebackground.Name = "filebackground";
            this.filebackground.Size = new System.Drawing.Size(170, 152);
            this.filebackground.TabIndex = 12;
            // 
            // fileType_ic
            // 
            this.fileType_ic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileType_ic.Image = global::Cloud_Storage_App.Properties.Resources.unknownFile_ic;
            this.fileType_ic.Location = new System.Drawing.Point(0, 0);
            this.fileType_ic.Name = "fileType_ic";
            this.fileType_ic.Padding = new System.Windows.Forms.Padding(15);
            this.fileType_ic.Size = new System.Drawing.Size(170, 152);
            this.fileType_ic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileType_ic.TabIndex = 4;
            this.fileType_ic.TabStop = false;
            // 
            // FileDetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.background_4_8K;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 524);
            this.Controls.Add(this.tableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileDetailsWindow";
            this.Text = "Cloud Storage App";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.filebackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileType_ic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel filename_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel create_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel filesize_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel filetype_lbl;
        private ePOSOne.btnProduct.Button_WOC close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel filebackground;
        private System.Windows.Forms.PictureBox fileType_ic;
    }
}