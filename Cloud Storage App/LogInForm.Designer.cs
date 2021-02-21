namespace Cloud_Storage_App
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usr_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.acc_back = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.back_btn = new ePOSOne.btnProduct.Button_WOC();
            this.log_btn = new ePOSOne.btnProduct.Button_WOC();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.remember = new Bunifu.Framework.UI.BunifuCheckbox();
            this.remember_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mainTable.SuspendLayout();
            this.acc_back.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cloud_Storage_App.Properties.Resources.acc_ic;
            this.pictureBox2.InitialImage = global::Cloud_Storage_App.Properties.Resources.acc_ic;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox2.Size = new System.Drawing.Size(180, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // usr_box
            // 
            this.usr_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.usr_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usr_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_box.ForeColor = System.Drawing.Color.White;
            this.usr_box.HintForeColor = System.Drawing.Color.White;
            this.usr_box.HintText = "Username";
            this.usr_box.isPassword = false;
            this.usr_box.LineFocusedColor = System.Drawing.Color.White;
            this.usr_box.LineIdleColor = System.Drawing.Color.Gray;
            this.usr_box.LineMouseHoverColor = System.Drawing.Color.White;
            this.usr_box.LineThickness = 3;
            this.usr_box.Location = new System.Drawing.Point(268, 7);
            this.usr_box.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.usr_box.Name = "usr_box";
            this.usr_box.Size = new System.Drawing.Size(467, 48);
            this.usr_box.TabIndex = 4;
            this.usr_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pass_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.ForeColor = System.Drawing.Color.White;
            this.pass_box.HintForeColor = System.Drawing.Color.White;
            this.pass_box.HintText = "Password";
            this.pass_box.isPassword = false;
            this.pass_box.LineFocusedColor = System.Drawing.Color.White;
            this.pass_box.LineIdleColor = System.Drawing.Color.Gray;
            this.pass_box.LineMouseHoverColor = System.Drawing.Color.White;
            this.pass_box.LineThickness = 3;
            this.pass_box.Location = new System.Drawing.Point(268, 7);
            this.pass_box.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(467, 48);
            this.pass_box.TabIndex = 5;
            this.pass_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass_box.OnValueChanged += new System.EventHandler(this.pass_box_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 518);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(242, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "CopyRight © Vlaviano Mario, 2020";
            // 
            // linkLabel
            // 
            this.linkLabel.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.White;
            this.linkLabel.Location = new System.Drawing.Point(4, 490);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(931, 21);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Create new account";
            this.linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::Cloud_Storage_App.Properties.Resources.user_ic;
            this.pictureBox3.Location = new System.Drawing.Point(204, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::Cloud_Storage_App.Properties.Resources.password_ic;
            this.pictureBox4.Location = new System.Drawing.Point(204, 13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // mainTable
            // 
            this.mainTable.BackColor = System.Drawing.Color.Transparent;
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Controls.Add(this.acc_back, 0, 1);
            this.mainTable.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.mainTable.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.mainTable.Controls.Add(this.back_btn, 0, 0);
            this.mainTable.Controls.Add(this.label1, 0, 7);
            this.mainTable.Controls.Add(this.linkLabel, 0, 6);
            this.mainTable.Controls.Add(this.log_btn, 0, 5);
            this.mainTable.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.mainTable.RowCount = 8;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.351884F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.27747F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.93359F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.93359F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.841862F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.70095F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.998663F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.962001F));
            this.mainTable.Size = new System.Drawing.Size(939, 543);
            this.mainTable.TabIndex = 11;
            // 
            // acc_back
            // 
            this.acc_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acc_back.BackColor = System.Drawing.Color.Transparent;
            this.acc_back.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.round_rect;
            this.acc_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acc_back.Controls.Add(this.pictureBox2);
            this.acc_back.Location = new System.Drawing.Point(379, 56);
            this.acc_back.Name = "acc_back";
            this.acc_back.Size = new System.Drawing.Size(180, 162);
            this.acc_back.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.9F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.1F));
            this.tableLayoutPanel3.Controls.Add(this.usr_box, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 232);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(932, 72);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.897F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.103F));
            this.tableLayoutPanel2.Controls.Add(this.pass_box, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(933, 74);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BorderColor = System.Drawing.Color.Transparent;
            this.back_btn.ButtonColor = System.Drawing.Color.White;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(4, 4);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.back_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.back_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.back_btn.Size = new System.Drawing.Size(88, 37);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "← Back";
            this.back_btn.TextColor = System.Drawing.Color.Maroon;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // log_btn
            // 
            this.log_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_btn.BackColor = System.Drawing.Color.Transparent;
            this.log_btn.BorderColor = System.Drawing.Color.Transparent;
            this.log_btn.ButtonColor = System.Drawing.Color.White;
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.log_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log_btn.Location = new System.Drawing.Point(379, 425);
            this.log_btn.Margin = new System.Windows.Forms.Padding(4);
            this.log_btn.Name = "log_btn";
            this.log_btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.log_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.log_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.log_btn.Size = new System.Drawing.Size(180, 57);
            this.log_btn.TabIndex = 0;
            this.log_btn.Text = "LogIn";
            this.log_btn.TextColor = System.Drawing.Color.Maroon;
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.87276F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.12724F));
            this.tableLayoutPanel1.Controls.Add(this.remember, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.remember_lbl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 392);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 25);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // remember
            // 
            this.remember.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.remember.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.remember.Checked = true;
            this.remember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.remember.ForeColor = System.Drawing.Color.White;
            this.remember.Location = new System.Drawing.Point(394, 4);
            this.remember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(20, 20);
            this.remember.TabIndex = 15;
            // 
            // remember_lbl
            // 
            this.remember_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.remember_lbl.AutoSize = true;
            this.remember_lbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remember_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.remember_lbl.Location = new System.Drawing.Point(421, 2);
            this.remember_lbl.Name = "remember_lbl";
            this.remember_lbl.Size = new System.Drawing.Size(119, 20);
            this.remember_lbl.TabIndex = 16;
            this.remember_lbl.Text = "Remember me?";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.log_reg_background_8K;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.mainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.acc_back.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC log_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usr_box;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel;
        private ePOSOne.btnProduct.Button_WOC back_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.Panel acc_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCheckbox remember;
        private Bunifu.Framework.UI.BunifuCustomLabel remember_lbl;
    }
}