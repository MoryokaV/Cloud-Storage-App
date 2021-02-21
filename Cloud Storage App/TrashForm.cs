// - - Code by Vlaviano  - - //

using Cloud_Storage_App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Cloud_Storage_App
{
    public partial class TrashForm : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrashForm));

        public static string[] filenames = new string[] { };

        public static int totalItems = 1;

        GroupBox[] boxes = new GroupBox[totalItems];

        List<Bitmap> icons = new List<Bitmap>();

        Label[] filenameLabels = new Label[totalItems];

        public TrashForm()
        {
            Client.getTrashFilenames(); //getting file names
            boxes = new GroupBox[totalItems]; //reinitializing array
            filenameLabels = new Label[totalItems]; //reinitializing array

            getIcons();//Getting file icons

            InitializeComponent();

            //Main Generator
            for (int iteration = 0; iteration < totalItems; iteration++)
            {
                boxes[iteration] = new GroupBox(){ Name = "groupBox" + (iteration).ToString()};

                boxes[iteration].BackColor = defaultGroupBox.BackColor;
                boxes[iteration].Controls.Add(createChildTable(iteration));
                boxes[iteration].Font = defaultGroupBox.Font;
                boxes[iteration].ForeColor = defaultGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
                boxes[iteration].Location = defaultGroupBox.Location;
                boxes[iteration].Size = defaultGroupBox.Size;
                boxes[iteration].TabIndex = defaultGroupBox.TabIndex;
                boxes[iteration].Dock = DockStyle.Top;
                boxes[iteration].TabStop = defaultGroupBox.TabStop;
                boxes[iteration].Visible = true;
                boxes[iteration].Text = "";

                table.RowCount++;
                //table.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                table.Controls.Add(boxes[iteration], 0, table.RowCount - 1);

            }
        }

        public Control createChildTable(int iteration)
        {
            TableLayoutPanel childTable = new TableLayoutPanel();
            childTable.BackColor = System.Drawing.Color.Transparent;
            childTable.ColumnCount = 4;
            childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.53764F));
            childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.13834F));
            childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.66201F));
            childTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.66201F));
            childTable.Controls.Add(createRestoreChild(iteration), 3, 0);
            childTable.Controls.Add(createDeleteChild(iteration), 2, 0);
            childTable.Controls.Add(generateFileBackground(iteration), 0, 0);
            childTable.Controls.Add(generateFilename_lbl(filenames[iteration], iteration), 1, 0);
            childTable.Dock = System.Windows.Forms.DockStyle.Fill;
            childTable.Location = new System.Drawing.Point(4, 29);
            childTable.Name = "def_childTable";
            childTable.RowCount = 1;
            childTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.61205F));
            childTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            childTable.Size = new System.Drawing.Size(493, 132);
            childTable.TabIndex = 16;
            return childTable;
        }

        public Control createDeleteChild(int iteration)
        {
            TableLayoutPanel deleteChild = new TableLayoutPanel();
            deleteChild.BackColor = System.Drawing.Color.Transparent;
            deleteChild.ColumnCount = 1;
            deleteChild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            deleteChild.Controls.Add(generateDeleteLbl(), 0, 1);
            deleteChild.Controls.Add(generateDeleteBtn(iteration), 0, 0);
            deleteChild.Location = new System.Drawing.Point(321, 3);
            deleteChild.Name = "def_deleteChild";
            deleteChild.RowCount = 2;
            deleteChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            deleteChild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            deleteChild.Size = new System.Drawing.Size(81, 126);
            deleteChild.TabIndex = 19;
            return deleteChild;
        }

        public Control createRestoreChild(int iteration)
        {
            TableLayoutPanel restore_child = new TableLayoutPanel();
            restore_child.BackColor = System.Drawing.Color.Transparent;
            restore_child.ColumnCount = 1;
            restore_child.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            restore_child.Controls.Add(generateRestoreLbl(), 0, 1);
            restore_child.Controls.Add(generateRestoreBtn(iteration), 0, 0);
            restore_child.Location = new System.Drawing.Point(408, 3);
            restore_child.Name = "def_restore_child";
            restore_child.RowCount = 2;
            restore_child.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.46377F));
            restore_child.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            restore_child.Size = new System.Drawing.Size(82, 126);
            restore_child.TabIndex = 19;

            return restore_child;
        }

        public void getIcons()
        {
            for(int i = 0; i < totalItems; i++)
            {
                string filetype = filenames[i].Substring(filenames[i].LastIndexOf(".") + 1);

                if (filetype == "zip" || filetype == "rar") icons.Add(Properties.Resources.winrar_ic);
                else if (filetype == "doc" || filetype == "docx") icons.Add(Properties.Resources.word_ic);
                else if (filetype == "xlsx" || filetype == "xls") icons.Add(Properties.Resources.excel_ic);
                else if (filetype == "ppt" || filetype == "pptx") icons.Add(Properties.Resources.ppt_ic);
                else if (filetype == "mp4") icons.Add(Properties.Resources.mp4_ic);
                else if (filetype == "mp3") icons.Add(Properties.Resources.mp3_ic);
                else if (filetype == "png" || filetype == "jpg" || filetype == "JPG" || filetype == "jpeg") icons.Add(Properties.Resources.photo_ic);
                else if (filetype == "txt" || filetype == "log") icons.Add(Properties.Resources.txt_ic);
                else if (filetype == "pdf") icons.Add(Properties.Resources.pdf_ic);
                else icons.Add(Properties.Resources.unknownFile_ic);
            }
        }

        public Control generateFile_ic(Bitmap icon)
        {
            PictureBox file_ic = new PictureBox();

            file_ic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            file_ic.Dock = System.Windows.Forms.DockStyle.Fill;
            file_ic.BackColor = System.Drawing.Color.Transparent;
            file_ic.Image = icon;
            file_ic.Padding = new System.Windows.Forms.Padding(15);
            file_ic.Location = new System.Drawing.Point(20, 9);
            file_ic.Name = "file_ic";
            file_ic.Size = new System.Drawing.Size(85, 85);
            file_ic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            file_ic.TabIndex = 1;
            file_ic.TabStop = false;

            return file_ic;
        }
        public Control generateFileBackground(int iteration)
        {
            Panel fileBackground = new Panel();
            fileBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            fileBackground.BackColor = System.Drawing.Color.Transparent;
            fileBackground.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.round_rect_white;
            fileBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            fileBackground.Controls.Add(generateFile_ic(icons[iteration]));
            fileBackground.Location = new System.Drawing.Point(7, 9);
            fileBackground.Name = "def_fileBackground";
            fileBackground.Size = new System.Drawing.Size(111, 115);
            fileBackground.TabIndex = 19;
            return fileBackground;
        }
        public Control generateRestoreLbl()
        {
            Label restore_lbl = new Label();

            restore_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            restore_lbl.BackColor = System.Drawing.Color.Transparent;
            restore_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restore_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            restore_lbl.Location = new System.Drawing.Point(4, 91);
            restore_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            restore_lbl.Name = "def_restore_lbl";
            restore_lbl.Size = new System.Drawing.Size(74, 35);
            restore_lbl.TabIndex = 14;
            restore_lbl.Text = "Restore";
            restore_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return restore_lbl;
        }

        public Control generateRestoreBtn(int iteration)
        {
            Bunifu.Framework.UI.BunifuImageButton restore_btn = new Bunifu.Framework.UI.BunifuImageButton();

            restore_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            restore_btn.BackColor = System.Drawing.Color.Transparent;
            restore_btn.Image = global::Cloud_Storage_App.Properties.Resources.restoreArrow;
            restore_btn.ImageActive = null;
            restore_btn.Location = new System.Drawing.Point(18, 31);
            restore_btn.Margin = new System.Windows.Forms.Padding(4);
            restore_btn.Name = "restore_btn_" + iteration;
            restore_btn.Size = new System.Drawing.Size(46, 56);
            restore_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            restore_btn.TabIndex = 4;
            restore_btn.TabStop = false;
            restore_btn.Zoom = 10;
            restore_btn.Click += new System.EventHandler(restore_btn_Click);

            return restore_btn;
        }
        public Control generateDeleteBtn(int iteration)
        {
            Bunifu.Framework.UI.BunifuImageButton delete_btn = new Bunifu.Framework.UI.BunifuImageButton();

            delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            delete_btn.BackColor = System.Drawing.Color.Transparent;
            delete_btn.Image = global::Cloud_Storage_App.Properties.Resources.trash_ic;
            delete_btn.ImageActive = null;
            delete_btn.Location = new System.Drawing.Point(17, 31);
            delete_btn.Margin = new System.Windows.Forms.Padding(4);
            delete_btn.Name = "delete_btn_" + iteration;
            delete_btn.Size = new System.Drawing.Size(46, 56);
            delete_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            delete_btn.TabIndex = 3;
            delete_btn.TabStop = false;
            delete_btn.Zoom = 10;
            delete_btn.Click += new System.EventHandler(delete_btn_Click);

            return delete_btn;
        }
        public Control generateDeleteLbl()
        {
            Label delete_lbl = new Label();

            delete_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            delete_lbl.BackColor = System.Drawing.Color.Transparent;
            delete_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delete_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            delete_lbl.Location = new System.Drawing.Point(4, 91);
            delete_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            delete_lbl.Name = "def_delete_lbl";
            delete_lbl.Size = new System.Drawing.Size(73, 35);
            delete_lbl.TabIndex = 13;
            delete_lbl.Text = "Delete";
            delete_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return delete_lbl;
        }
        
        public Control generateFilename_lbl(string filename,int iteration)
        {
            filenameLabels[iteration] = new Label();

            if(filename.Length <= 33)
                filenameLabels[iteration].Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            else
                filenameLabels[iteration].Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            filenameLabels[iteration].Location = new System.Drawing.Point(134, 0);
            filenameLabels[iteration].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            filenameLabels[iteration].Name = "def_filename_lbl";
            filenameLabels[iteration].Size = new System.Drawing.Size(179, 132);
            filenameLabels[iteration].TabIndex = 2;
            filenameLabels[iteration].Text = filenames[iteration];
            filenameLabels[iteration].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return filenameLabels[iteration];
        }

        private void DeleteAll_btn_Click(object sender, EventArgs e)
        {   
            if(table.RowCount != 0)
            {
                Client.deleteTrash();

                for (int i = 0; i <= boxes.Length - 1; i++)
                {
                    table.Controls.Remove(boxes[i]);
                    table.RowCount = table.RowCount - 1;
                }
            }
            else
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Trash bin is Empty! :)");
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            CloudManager cloudManager = new CloudManager();
            cloudManager.Show();
            cloudManager.Closed += (s, args) => this.Close();
            this.Hide();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Bunifu.Framework.UI.BunifuImageButton;
            int iteration = Int32.Parse(btn.Name.Substring(btn.Name.LastIndexOf("_") + 1));
            string filename = filenameLabels[iteration].Text;

            Client.deleteTrashFile(filename);

            table.Controls.Remove(boxes[iteration]);

            for (int i = iteration + 1; i <= boxes.Length - 1; i++)
                table.SetRow(boxes[i], table.GetRow(boxes[i]) - 1);

            table.RowCount = table.RowCount - 1;

            closeTheWindow();
        }
        private void restore_btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Bunifu.Framework.UI.BunifuImageButton;
            int iteration = Int32.Parse(btn.Name.Substring(btn.Name.LastIndexOf("_") + 1));
            string filename = filenameLabels[iteration].Text;

            Client.restoreTrashFile(filename);

            table.Controls.Remove(boxes[iteration]);

            for (int i = iteration + 1; i <= boxes.Length - 1; i++)
                table.SetRow(boxes[i], table.GetRow(boxes[i]) - 1);

            table.RowCount = table.RowCount - 1;

            closeTheWindow();
        }

        public void closeTheWindow()
        {
            if(table.RowCount == 1)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Good Job! - Trash bin is empty!");

                CloudManager cloudManager = new CloudManager();
                cloudManager.Show();
                cloudManager.Closed += (s, args) => this.Close();
                this.Hide();
            }
        }
    }
}
