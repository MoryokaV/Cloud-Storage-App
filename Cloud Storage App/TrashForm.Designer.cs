namespace Cloud_Storage_App
{
    partial class TrashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrashForm));
            this.title = new System.Windows.Forms.Label();
            this.winTrashImg = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.defaultGroupBox = new System.Windows.Forms.GroupBox();
            this.def_childTable = new System.Windows.Forms.TableLayoutPanel();
            this.def_restore_child = new System.Windows.Forms.TableLayoutPanel();
            this.def_restore_lbl = new System.Windows.Forms.Label();
            this.def_restore_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.def_deleteChild = new System.Windows.Forms.TableLayoutPanel();
            this.def_delete_lbl = new System.Windows.Forms.Label();
            this.def_delete_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.def_fileBackground = new System.Windows.Forms.Panel();
            this.def_file_ic = new System.Windows.Forms.PictureBox();
            this.def_filename_lbl = new System.Windows.Forms.Label();
            this.DeleteAll_btn = new ePOSOne.btnProduct.Button_WOC();
            this.close_btn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.winTrashImg)).BeginInit();
            this.defaultGroupBox.SuspendLayout();
            this.def_childTable.SuspendLayout();
            this.def_restore_child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.def_restore_btn)).BeginInit();
            this.def_deleteChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.def_delete_btn)).BeginInit();
            this.def_fileBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.def_file_ic)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(16, 11);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(509, 59);
            this.title.TabIndex = 0;
            this.title.Text = "Trash Bin";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winTrashImg
            // 
            this.winTrashImg.BackColor = System.Drawing.Color.Transparent;
            this.winTrashImg.Image = global::Cloud_Storage_App.Properties.Resources.winTrash;
            this.winTrashImg.Location = new System.Drawing.Point(452, 10);
            this.winTrashImg.Margin = new System.Windows.Forms.Padding(4);
            this.winTrashImg.Name = "winTrashImg";
            this.winTrashImg.Size = new System.Drawing.Size(73, 68);
            this.winTrashImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winTrashImg.TabIndex = 4;
            this.winTrashImg.TabStop = false;
            // 
            // table
            // 
            this.table.AutoScroll = true;
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Location = new System.Drawing.Point(16, 86);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(509, 464);
            this.table.TabIndex = 18;
            // 
            // defaultGroupBox
            // 
            this.defaultGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.defaultGroupBox.Controls.Add(this.def_childTable);
            this.defaultGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.defaultGroupBox.Location = new System.Drawing.Point(533, 86);
            this.defaultGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.defaultGroupBox.Name = "defaultGroupBox";
            this.defaultGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.defaultGroupBox.Size = new System.Drawing.Size(501, 165);
            this.defaultGroupBox.TabIndex = 18;
            this.defaultGroupBox.TabStop = false;
            this.defaultGroupBox.Visible = false;
            // 
            // def_childTable
            // 
            this.def_childTable.BackColor = System.Drawing.Color.Transparent;
            this.def_childTable.ColumnCount = 4;
            this.def_childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.53764F));
            this.def_childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.13834F));
            this.def_childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.66201F));
            this.def_childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.66201F));
            this.def_childTable.Controls.Add(this.def_restore_child, 3, 0);
            this.def_childTable.Controls.Add(this.def_deleteChild, 2, 0);
            this.def_childTable.Controls.Add(this.def_fileBackground, 0, 0);
            this.def_childTable.Controls.Add(this.def_filename_lbl, 1, 0);
            this.def_childTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.def_childTable.Location = new System.Drawing.Point(4, 29);
            this.def_childTable.Name = "def_childTable";
            this.def_childTable.RowCount = 1;
            this.def_childTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.61205F));
            this.def_childTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.def_childTable.Size = new System.Drawing.Size(493, 132);
            this.def_childTable.TabIndex = 16;
            // 
            // def_restore_child
            // 
            this.def_restore_child.BackColor = System.Drawing.Color.Transparent;
            this.def_restore_child.ColumnCount = 1;
            this.def_restore_child.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.def_restore_child.Controls.Add(this.def_restore_lbl, 0, 1);
            this.def_restore_child.Controls.Add(this.def_restore_btn, 0, 0);
            this.def_restore_child.Location = new System.Drawing.Point(408, 3);
            this.def_restore_child.Name = "def_restore_child";
            this.def_restore_child.RowCount = 2;
            this.def_restore_child.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            this.def_restore_child.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.def_restore_child.Size = new System.Drawing.Size(82, 126);
            this.def_restore_child.TabIndex = 19;
            // 
            // def_restore_lbl
            // 
            this.def_restore_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.def_restore_lbl.BackColor = System.Drawing.Color.Transparent;
            this.def_restore_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_restore_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.def_restore_lbl.Location = new System.Drawing.Point(4, 91);
            this.def_restore_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.def_restore_lbl.Name = "def_restore_lbl";
            this.def_restore_lbl.Size = new System.Drawing.Size(74, 35);
            this.def_restore_lbl.TabIndex = 14;
            this.def_restore_lbl.Text = "Restore";
            this.def_restore_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // def_restore_btn
            // 
            this.def_restore_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.def_restore_btn.BackColor = System.Drawing.Color.Transparent;
            this.def_restore_btn.Image = global::Cloud_Storage_App.Properties.Resources.restoreArrow;
            this.def_restore_btn.ImageActive = null;
            this.def_restore_btn.Location = new System.Drawing.Point(18, 31);
            this.def_restore_btn.Margin = new System.Windows.Forms.Padding(4);
            this.def_restore_btn.Name = "def_restore_btn";
            this.def_restore_btn.Size = new System.Drawing.Size(46, 56);
            this.def_restore_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.def_restore_btn.TabIndex = 4;
            this.def_restore_btn.TabStop = false;
            this.def_restore_btn.Zoom = 10;
            // 
            // def_deleteChild
            // 
            this.def_deleteChild.BackColor = System.Drawing.Color.Transparent;
            this.def_deleteChild.ColumnCount = 1;
            this.def_deleteChild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.def_deleteChild.Controls.Add(this.def_delete_lbl, 0, 1);
            this.def_deleteChild.Controls.Add(this.def_delete_btn, 0, 0);
            this.def_deleteChild.Location = new System.Drawing.Point(321, 3);
            this.def_deleteChild.Name = "def_deleteChild";
            this.def_deleteChild.RowCount = 2;
            this.def_deleteChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            this.def_deleteChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.def_deleteChild.Size = new System.Drawing.Size(81, 126);
            this.def_deleteChild.TabIndex = 19;
            // 
            // def_delete_lbl
            // 
            this.def_delete_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.def_delete_lbl.BackColor = System.Drawing.Color.Transparent;
            this.def_delete_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_delete_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.def_delete_lbl.Location = new System.Drawing.Point(4, 91);
            this.def_delete_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.def_delete_lbl.Name = "def_delete_lbl";
            this.def_delete_lbl.Size = new System.Drawing.Size(73, 35);
            this.def_delete_lbl.TabIndex = 13;
            this.def_delete_lbl.Text = "Delete";
            this.def_delete_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // def_delete_btn
            // 
            this.def_delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.def_delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.def_delete_btn.Image = global::Cloud_Storage_App.Properties.Resources.trash_ic;
            this.def_delete_btn.ImageActive = null;
            this.def_delete_btn.Location = new System.Drawing.Point(17, 31);
            this.def_delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.def_delete_btn.Name = "def_delete_btn";
            this.def_delete_btn.Size = new System.Drawing.Size(46, 56);
            this.def_delete_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.def_delete_btn.TabIndex = 3;
            this.def_delete_btn.TabStop = false;
            this.def_delete_btn.Zoom = 10;
            // 
            // def_fileBackground
            // 
            this.def_fileBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.def_fileBackground.BackColor = System.Drawing.Color.Transparent;
            this.def_fileBackground.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.round_rect_white;
            this.def_fileBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.def_fileBackground.Controls.Add(this.def_file_ic);
            this.def_fileBackground.Location = new System.Drawing.Point(9, 8);
            this.def_fileBackground.Name = "def_fileBackground";
            this.def_fileBackground.Size = new System.Drawing.Size(111, 115);
            this.def_fileBackground.TabIndex = 19;
            // 
            // def_file_ic
            // 
            this.def_file_ic.BackColor = System.Drawing.Color.Transparent;
            this.def_file_ic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.def_file_ic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.def_file_ic.Image = global::Cloud_Storage_App.Properties.Resources.mp4_ic;
            this.def_file_ic.Location = new System.Drawing.Point(0, 0);
            this.def_file_ic.Margin = new System.Windows.Forms.Padding(4);
            this.def_file_ic.Name = "def_file_ic";
            this.def_file_ic.Padding = new System.Windows.Forms.Padding(15);
            this.def_file_ic.Size = new System.Drawing.Size(111, 115);
            this.def_file_ic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.def_file_ic.TabIndex = 1;
            this.def_file_ic.TabStop = false;
            // 
            // def_filename_lbl
            // 
            this.def_filename_lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_filename_lbl.Location = new System.Drawing.Point(134, 0);
            this.def_filename_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.def_filename_lbl.Name = "def_filename_lbl";
            this.def_filename_lbl.Size = new System.Drawing.Size(179, 132);
            this.def_filename_lbl.TabIndex = 2;
            this.def_filename_lbl.Text = "aaaaaaaaaaaaaaaaaaaa";
            this.def_filename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteAll_btn
            // 
            this.DeleteAll_btn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.BorderColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.ButtonColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteAll_btn.FlatAppearance.BorderSize = 0;
            this.DeleteAll_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAll_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAll_btn.Location = new System.Drawing.Point(275, 558);
            this.DeleteAll_btn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteAll_btn.Name = "DeleteAll_btn";
            this.DeleteAll_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.DeleteAll_btn.OnHoverTextColor = System.Drawing.Color.Silver;
            this.DeleteAll_btn.Size = new System.Drawing.Size(250, 36);
            this.DeleteAll_btn.TabIndex = 11;
            this.DeleteAll_btn.Text = "Delete All ✖";
            this.DeleteAll_btn.TextColor = System.Drawing.Color.Gainsboro;
            this.DeleteAll_btn.UseVisualStyleBackColor = false;
            this.DeleteAll_btn.Click += new System.EventHandler(this.DeleteAll_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BorderColor = System.Drawing.Color.Transparent;
            this.close_btn.ButtonColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(16, 558);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverTextColor = System.Drawing.Color.Silver;
            this.close_btn.Size = new System.Drawing.Size(251, 36);
            this.close_btn.TabIndex = 10;
            this.close_btn.Text = "← Close ";
            this.close_btn.TextColor = System.Drawing.Color.Gainsboro;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // TrashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(538, 615);
            this.Controls.Add(this.defaultGroupBox);
            this.Controls.Add(this.table);
            this.Controls.Add(this.winTrashImg);
            this.Controls.Add(this.DeleteAll_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TrashForm";
            this.Text = "Cloud Storage App";
            ((System.ComponentModel.ISupportInitialize)(this.winTrashImg)).EndInit();
            this.defaultGroupBox.ResumeLayout(false);
            this.def_childTable.ResumeLayout(false);
            this.def_restore_child.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.def_restore_btn)).EndInit();
            this.def_deleteChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.def_delete_btn)).EndInit();
            this.def_fileBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.def_file_ic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private ePOSOne.btnProduct.Button_WOC close_btn;
        private ePOSOne.btnProduct.Button_WOC DeleteAll_btn;
        private System.Windows.Forms.PictureBox winTrashImg;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.GroupBox defaultGroupBox;
        private System.Windows.Forms.Label def_restore_lbl;
        private System.Windows.Forms.Label def_delete_lbl;
        private Bunifu.Framework.UI.BunifuImageButton def_restore_btn;
        private Bunifu.Framework.UI.BunifuImageButton def_delete_btn;
        private System.Windows.Forms.Label def_filename_lbl;
        private System.Windows.Forms.TableLayoutPanel def_childTable;
        private System.Windows.Forms.PictureBox def_file_ic;
        private System.Windows.Forms.Panel def_fileBackground;
        private System.Windows.Forms.TableLayoutPanel def_deleteChild;
        private System.Windows.Forms.TableLayoutPanel def_restore_child;
    }
}