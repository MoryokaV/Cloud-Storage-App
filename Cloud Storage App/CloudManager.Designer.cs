namespace Cloud_Storage_App
{
    partial class CloudManager
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudManager));
            this.label3 = new System.Windows.Forms.Label();
            this.file_combo = new System.Windows.Forms.ComboBox();
            this.info_lbl = new System.Windows.Forms.Label();
            this.fileType_ic = new System.Windows.Forms.PictureBox();
            this.sidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tableLayoutSidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.childTable = new System.Windows.Forms.TableLayoutPanel();
            this.menu_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trash_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usr_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.accType_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cloudSize_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.files_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.trash_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buy_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slide_animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menu_btn2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.procent_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.space_txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.back_btn = new ePOSOne.btnProduct.Button_WOC();
            this.details_btn = new ePOSOne.btnProduct.Button_WOC();
            this.open_btn = new ePOSOne.btnProduct.Button_WOC();
            this.delete_btn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.fileType_ic)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.tableLayoutSidePanel.SuspendLayout();
            this.childTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(915, 38);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cloud Manager";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // file_combo
            // 
            this.file_combo.BackColor = System.Drawing.Color.SlateGray;
            this.slide_animation.SetDecoration(this.file_combo, BunifuAnimatorNS.DecorationType.None);
            this.file_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.file_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_combo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.file_combo.FormattingEnabled = true;
            this.file_combo.Location = new System.Drawing.Point(445, 156);
            this.file_combo.Margin = new System.Windows.Forms.Padding(4);
            this.file_combo.Name = "file_combo";
            this.file_combo.Size = new System.Drawing.Size(476, 32);
            this.file_combo.TabIndex = 22;
            this.file_combo.TabStop = false;
            this.file_combo.SelectedIndexChanged += new System.EventHandler(this.file_combo_SelectedIndexChanged);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.info_lbl, BunifuAnimatorNS.DecorationType.None);
            this.info_lbl.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.info_lbl.Location = new System.Drawing.Point(16, 159);
            this.info_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(339, 29);
            this.info_lbl.TabIndex = 23;
            this.info_lbl.Text = "Select your file to manage:";
            // 
            // fileType_ic
            // 
            this.fileType_ic.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.fileType_ic, BunifuAnimatorNS.DecorationType.None);
            this.fileType_ic.Image = global::Cloud_Storage_App.Properties.Resources.unknownFile_ic;
            this.fileType_ic.InitialImage = null;
            this.fileType_ic.Location = new System.Drawing.Point(380, 151);
            this.fileType_ic.Margin = new System.Windows.Forms.Padding(4);
            this.fileType_ic.Name = "fileType_ic";
            this.fileType_ic.Size = new System.Drawing.Size(51, 43);
            this.fileType_ic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileType_ic.TabIndex = 25;
            this.fileType_ic.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel.BackgroundImage")));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Controls.Add(this.tableLayoutSidePanel);
            this.sidePanel.Controls.Add(this.trash_btn);
            this.sidePanel.Controls.Add(this.buy_btn);
            this.slide_animation.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.sidePanel.GradientBottomLeft = System.Drawing.Color.DarkGoldenrod;
            this.sidePanel.GradientBottomRight = System.Drawing.Color.Tan;
            this.sidePanel.GradientTopLeft = System.Drawing.Color.BurlyWood;
            this.sidePanel.GradientTopRight = System.Drawing.Color.NavajoWhite;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Quality = 10;
            this.sidePanel.Size = new System.Drawing.Size(0, 543);
            this.sidePanel.TabIndex = 31;
            // 
            // tableLayoutSidePanel
            // 
            this.tableLayoutSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutSidePanel.ColumnCount = 1;
            this.tableLayoutSidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSidePanel.Controls.Add(this.childTable, 0, 0);
            this.tableLayoutSidePanel.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutSidePanel.Controls.Add(this.trash_lbl, 0, 7);
            this.tableLayoutSidePanel.Controls.Add(this.usr_lbl, 0, 2);
            this.tableLayoutSidePanel.Controls.Add(this.bunifuCustomLabel3, 0, 3);
            this.tableLayoutSidePanel.Controls.Add(this.accType_lbl, 0, 6);
            this.tableLayoutSidePanel.Controls.Add(this.cloudSize_lbl, 0, 4);
            this.tableLayoutSidePanel.Controls.Add(this.files_lbl, 0, 5);
            this.slide_animation.SetDecoration(this.tableLayoutSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutSidePanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutSidePanel.Name = "tableLayoutSidePanel";
            this.tableLayoutSidePanel.RowCount = 8;
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11026F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.06403F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544046F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11673F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11673F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11673F));
            this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00556F));
            this.tableLayoutSidePanel.Size = new System.Drawing.Size(275, 443);
            this.tableLayoutSidePanel.TabIndex = 33;
            // 
            // childTable
            // 
            this.childTable.BackColor = System.Drawing.Color.Transparent;
            this.childTable.ColumnCount = 2;
            this.childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14304F));
            this.childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.85696F));
            this.childTable.Controls.Add(this.menu_btn, 0, 0);
            this.childTable.Controls.Add(this.bunifuCustomLabel1, 1, 0);
            this.slide_animation.SetDecoration(this.childTable, BunifuAnimatorNS.DecorationType.None);
            this.childTable.Location = new System.Drawing.Point(3, 3);
            this.childTable.Name = "childTable";
            this.childTable.RowCount = 1;
            this.childTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.childTable.Size = new System.Drawing.Size(268, 71);
            this.childTable.TabIndex = 34;
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.menu_btn, BunifuAnimatorNS.DecorationType.None);
            this.menu_btn.Image = global::Cloud_Storage_App.Properties.Resources.menu_ic;
            this.menu_btn.ImageActive = null;
            this.menu_btn.Location = new System.Drawing.Point(4, 4);
            this.menu_btn.Margin = new System.Windows.Forms.Padding(4);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(67, 62);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_btn.TabIndex = 1;
            this.menu_btn.TabStop = false;
            this.menu_btn.Zoom = 10;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(100, 19);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(164, 32);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "PROFILE";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Cloud_Storage_App.Properties.Resources.acc_ic;
            this.pictureBox1.Location = new System.Drawing.Point(4, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // trash_lbl
            // 
            this.trash_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trash_lbl.AutoSize = true;
            this.trash_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.trash_lbl, BunifuAnimatorNS.DecorationType.None);
            this.trash_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trash_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.trash_lbl.Location = new System.Drawing.Point(4, 406);
            this.trash_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trash_lbl.Name = "trash_lbl";
            this.trash_lbl.Size = new System.Drawing.Size(267, 22);
            this.trash_lbl.TabIndex = 10;
            this.trash_lbl.Text = "Trash Size: 0.00 MB";
            this.trash_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usr_lbl
            // 
            this.usr_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_lbl.AutoSize = true;
            this.usr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.usr_lbl, BunifuAnimatorNS.DecorationType.None);
            this.usr_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usr_lbl.Location = new System.Drawing.Point(4, 198);
            this.usr_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usr_lbl.Name = "usr_lbl";
            this.usr_lbl.Size = new System.Drawing.Size(267, 23);
            this.usr_lbl.TabIndex = 5;
            this.usr_lbl.Text = "Moryoka";
            this.usr_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(4, 225);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(267, 20);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "-----------------------------";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accType_lbl
            // 
            this.accType_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.accType_lbl.AutoSize = true;
            this.accType_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.accType_lbl, BunifuAnimatorNS.DecorationType.None);
            this.accType_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accType_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accType_lbl.Location = new System.Drawing.Point(4, 356);
            this.accType_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accType_lbl.Name = "accType_lbl";
            this.accType_lbl.Size = new System.Drawing.Size(267, 22);
            this.accType_lbl.TabIndex = 8;
            this.accType_lbl.Text = "Account Type: Standard";
            this.accType_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cloudSize_lbl
            // 
            this.cloudSize_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cloudSize_lbl.AutoSize = true;
            this.cloudSize_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.cloudSize_lbl, BunifuAnimatorNS.DecorationType.None);
            this.cloudSize_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudSize_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cloudSize_lbl.Location = new System.Drawing.Point(4, 258);
            this.cloudSize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cloudSize_lbl.Name = "cloudSize_lbl";
            this.cloudSize_lbl.Size = new System.Drawing.Size(267, 22);
            this.cloudSize_lbl.TabIndex = 4;
            this.cloudSize_lbl.Text = "Storage Space: 16.0GB\r\n";
            this.cloudSize_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // files_lbl
            // 
            this.files_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.files_lbl.AutoSize = true;
            this.files_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.files_lbl, BunifuAnimatorNS.DecorationType.None);
            this.files_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.files_lbl.Location = new System.Drawing.Point(4, 307);
            this.files_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.files_lbl.Name = "files_lbl";
            this.files_lbl.Size = new System.Drawing.Size(267, 22);
            this.files_lbl.TabIndex = 6;
            this.files_lbl.Text = "Files Stored: 100";
            this.files_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trash_btn
            // 
            this.trash_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.trash_btn.BackColor = System.Drawing.Color.Gray;
            this.trash_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trash_btn.BorderRadius = 0;
            this.trash_btn.ButtonText = "Trash Bin";
            this.trash_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slide_animation.SetDecoration(this.trash_btn, BunifuAnimatorNS.DecorationType.None);
            this.trash_btn.DisabledColor = System.Drawing.Color.DimGray;
            this.trash_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trash_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trash_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.trash_btn.Iconimage = global::Cloud_Storage_App.Properties.Resources.trash_ic;
            this.trash_btn.Iconimage_right = null;
            this.trash_btn.Iconimage_right_Selected = null;
            this.trash_btn.Iconimage_Selected = null;
            this.trash_btn.IconMarginLeft = 0;
            this.trash_btn.IconMarginRight = 0;
            this.trash_btn.IconRightVisible = true;
            this.trash_btn.IconRightZoom = 0D;
            this.trash_btn.IconVisible = true;
            this.trash_btn.IconZoom = 45D;
            this.trash_btn.IsTab = false;
            this.trash_btn.Location = new System.Drawing.Point(0, 443);
            this.trash_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trash_btn.Name = "trash_btn";
            this.trash_btn.Normalcolor = System.Drawing.Color.Gray;
            this.trash_btn.OnHovercolor = System.Drawing.Color.DarkGray;
            this.trash_btn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.trash_btn.selected = false;
            this.trash_btn.Size = new System.Drawing.Size(0, 50);
            this.trash_btn.TabIndex = 9;
            this.trash_btn.Text = "Trash Bin";
            this.trash_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trash_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.trash_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trash_btn.Click += new System.EventHandler(this.trash_btn_Click);
            // 
            // buy_btn
            // 
            this.buy_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buy_btn.BackColor = System.Drawing.Color.Gray;
            this.buy_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buy_btn.BorderRadius = 0;
            this.buy_btn.ButtonText = "     Buy Storage Space";
            this.buy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slide_animation.SetDecoration(this.buy_btn, BunifuAnimatorNS.DecorationType.None);
            this.buy_btn.DisabledColor = System.Drawing.Color.DimGray;
            this.buy_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buy_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.buy_btn.Iconimage = global::Cloud_Storage_App.Properties.Resources.cart_ic;
            this.buy_btn.Iconimage_right = null;
            this.buy_btn.Iconimage_right_Selected = null;
            this.buy_btn.Iconimage_Selected = null;
            this.buy_btn.IconMarginLeft = 0;
            this.buy_btn.IconMarginRight = 0;
            this.buy_btn.IconRightVisible = true;
            this.buy_btn.IconRightZoom = 0D;
            this.buy_btn.IconVisible = true;
            this.buy_btn.IconZoom = 45D;
            this.buy_btn.IsTab = false;
            this.buy_btn.Location = new System.Drawing.Point(0, 493);
            this.buy_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Normalcolor = System.Drawing.Color.Gray;
            this.buy_btn.OnHovercolor = System.Drawing.Color.DarkGray;
            this.buy_btn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.buy_btn.selected = false;
            this.buy_btn.Size = new System.Drawing.Size(0, 50);
            this.buy_btn.TabIndex = 0;
            this.buy_btn.Text = "     Buy Storage Space";
            this.buy_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buy_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buy_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // slide_animation
            // 
            this.slide_animation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.slide_animation.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.slide_animation.DefaultAnimation = animation3;
            // 
            // menu_btn2
            // 
            this.menu_btn2.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.menu_btn2, BunifuAnimatorNS.DecorationType.None);
            this.menu_btn2.Image = global::Cloud_Storage_App.Properties.Resources.menu_ic;
            this.menu_btn2.ImageActive = null;
            this.menu_btn2.Location = new System.Drawing.Point(8, 10);
            this.menu_btn2.Margin = new System.Windows.Forms.Padding(4);
            this.menu_btn2.Name = "menu_btn2";
            this.menu_btn2.Size = new System.Drawing.Size(67, 62);
            this.menu_btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_btn2.TabIndex = 2;
            this.menu_btn2.TabStop = false;
            this.menu_btn2.Zoom = 10;
            this.menu_btn2.Click += new System.EventHandler(this.menu_btn2_Click);
            // 
            // procent_lbl
            // 
            this.procent_lbl.AutoSize = true;
            this.procent_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.procent_lbl, BunifuAnimatorNS.DecorationType.None);
            this.procent_lbl.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procent_lbl.ForeColor = System.Drawing.Color.White;
            this.procent_lbl.Location = new System.Drawing.Point(852, 490);
            this.procent_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.procent_lbl.Name = "procent_lbl";
            this.procent_lbl.Size = new System.Drawing.Size(83, 38);
            this.procent_lbl.TabIndex = 35;
            this.procent_lbl.Text = "100.00%";
            // 
            // space_txt
            // 
            this.space_txt.AutoSize = true;
            this.space_txt.BackColor = System.Drawing.Color.Transparent;
            this.slide_animation.SetDecoration(this.space_txt, BunifuAnimatorNS.DecorationType.None);
            this.space_txt.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space_txt.ForeColor = System.Drawing.Color.White;
            this.space_txt.Location = new System.Drawing.Point(8, 489);
            this.space_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.space_txt.Name = "space_txt";
            this.space_txt.Size = new System.Drawing.Size(349, 45);
            this.space_txt.TabIndex = 34;
            this.space_txt.Text = "Storage Available: 0.00GB / 16.00GB";
            // 
            // pbar
            // 
            this.pbar.BackColor = System.Drawing.Color.Silver;
            this.pbar.BorderRadius = 5;
            this.slide_animation.SetDecoration(this.pbar, BunifuAnimatorNS.DecorationType.None);
            this.pbar.Location = new System.Drawing.Point(377, 500);
            this.pbar.Margin = new System.Windows.Forms.Padding(5);
            this.pbar.MaximumValue = 100;
            this.pbar.Name = "pbar";
            this.pbar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.pbar.Size = new System.Drawing.Size(467, 18);
            this.pbar.TabIndex = 33;
            this.pbar.Value = 0;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BorderColor = System.Drawing.Color.Transparent;
            this.back_btn.ButtonColor = System.Drawing.Color.Gainsboro;
            this.slide_animation.SetDecoration(this.back_btn, BunifuAnimatorNS.DecorationType.None);
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(777, 17);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.back_btn.Size = new System.Drawing.Size(145, 36);
            this.back_btn.TabIndex = 32;
            this.back_btn.Text = "← Main Menu";
            this.back_btn.TextColor = System.Drawing.Color.Maroon;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // details_btn
            // 
            this.details_btn.BackColor = System.Drawing.Color.Transparent;
            this.details_btn.BorderColor = System.Drawing.Color.Transparent;
            this.details_btn.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.slide_animation.SetDecoration(this.details_btn, BunifuAnimatorNS.DecorationType.None);
            this.details_btn.FlatAppearance.BorderSize = 0;
            this.details_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.details_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.details_btn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.details_btn.Location = new System.Drawing.Point(743, 242);
            this.details_btn.Margin = new System.Windows.Forms.Padding(4);
            this.details_btn.Name = "details_btn";
            this.details_btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.details_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.details_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.details_btn.Size = new System.Drawing.Size(180, 53);
            this.details_btn.TabIndex = 30;
            this.details_btn.Text = "Details ☰";
            this.details_btn.TextColor = System.Drawing.Color.Maroon;
            this.details_btn.UseVisualStyleBackColor = false;
            this.details_btn.Visible = false;
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.Transparent;
            this.open_btn.BorderColor = System.Drawing.Color.Transparent;
            this.open_btn.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.slide_animation.SetDecoration(this.open_btn, BunifuAnimatorNS.DecorationType.None);
            this.open_btn.FlatAppearance.BorderSize = 0;
            this.open_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.open_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_btn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.open_btn.Location = new System.Drawing.Point(380, 242);
            this.open_btn.Margin = new System.Windows.Forms.Padding(4);
            this.open_btn.Name = "open_btn";
            this.open_btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.open_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.open_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.open_btn.Size = new System.Drawing.Size(180, 53);
            this.open_btn.TabIndex = 29;
            this.open_btn.Text = "Open ➤";
            this.open_btn.TextColor = System.Drawing.Color.Maroon;
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Visible = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.BorderColor = System.Drawing.Color.Transparent;
            this.delete_btn.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.slide_animation.SetDecoration(this.delete_btn, BunifuAnimatorNS.DecorationType.None);
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_btn.Location = new System.Drawing.Point(16, 242);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.delete_btn.OnHoverButtonColor = System.Drawing.Color.White;
            this.delete_btn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.delete_btn.Size = new System.Drawing.Size(180, 53);
            this.delete_btn.TabIndex = 28;
            this.delete_btn.Text = "Delete ✗";
            this.delete_btn.TextColor = System.Drawing.Color.Maroon;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // CloudManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.menu_btn2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.fileType_ic);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.file_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.procent_lbl);
            this.Controls.Add(this.space_txt);
            this.Controls.Add(this.pbar);
            this.slide_animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CloudManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Storage App";
            ((System.ComponentModel.ISupportInitialize)(this.fileType_ic)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.tableLayoutSidePanel.ResumeLayout(false);
            this.tableLayoutSidePanel.PerformLayout();
            this.childTable.ResumeLayout(false);
            this.childTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox file_combo;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.PictureBox fileType_ic;
        private ePOSOne.btnProduct.Button_WOC delete_btn;
        private ePOSOne.btnProduct.Button_WOC open_btn;
        private ePOSOne.btnProduct.Button_WOC details_btn;
        private Bunifu.Framework.UI.BunifuGradientPanel sidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton buy_btn;
        private BunifuAnimatorNS.BunifuTransition slide_animation;
        private Bunifu.Framework.UI.BunifuImageButton menu_btn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel cloudSize_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel usr_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel files_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel accType_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel trash_lbl;
        private Bunifu.Framework.UI.BunifuFlatButton trash_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private ePOSOne.btnProduct.Button_WOC back_btn;
        private Bunifu.Framework.UI.BunifuImageButton menu_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSidePanel;
        private System.Windows.Forms.TableLayoutPanel childTable;
        private Bunifu.Framework.UI.BunifuCustomLabel procent_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel space_txt;
        private Bunifu.Framework.UI.BunifuProgressBar pbar;
    }
}