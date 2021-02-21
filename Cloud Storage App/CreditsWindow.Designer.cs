namespace Cloud_Storage_App
{
    partial class CreditsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsWindow));
            this.credits_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signature = new System.Windows.Forms.PictureBox();
            this.close_btn = new ePOSOne.btnProduct.Button_WOC();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.googlePlay = new System.Windows.Forms.PictureBox();
            this.miniTable = new System.Windows.Forms.TableLayoutPanel();
            this.olx = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.signature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.googlePlay)).BeginInit();
            this.miniTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olx)).BeginInit();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // credits_lbl
            // 
            this.credits_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.credits_lbl.BackColor = System.Drawing.Color.Transparent;
            this.credits_lbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.credits_lbl.Location = new System.Drawing.Point(4, 153);
            this.credits_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.credits_lbl.Name = "credits_lbl";
            this.credits_lbl.Size = new System.Drawing.Size(499, 71);
            this.credits_lbl.TabIndex = 15;
            this.credits_lbl.Text = "Author: Vlaviano Mario - VMA Software";
            this.credits_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signature
            // 
            this.signature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.signature.BackColor = System.Drawing.Color.Transparent;
            this.signature.Image = global::Cloud_Storage_App.Properties.Resources.Signature;
            this.signature.Location = new System.Drawing.Point(178, 3);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(150, 147);
            this.signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature.TabIndex = 16;
            this.signature.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BorderColor = System.Drawing.Color.Transparent;
            this.close_btn.ButtonColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.Gray;
            this.close_btn.Location = new System.Drawing.Point(4, 313);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.close_btn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.close_btn.Size = new System.Drawing.Size(499, 36);
            this.close_btn.TabIndex = 31;
            this.close_btn.Text = "- Exit -";
            this.close_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // facebook
            // 
            this.facebook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.facebook.BackColor = System.Drawing.Color.Transparent;
            this.facebook.Image = global::Cloud_Storage_App.Properties.Resources.facebook_ic;
            this.facebook.Location = new System.Drawing.Point(89, 3);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(75, 72);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebook.TabIndex = 32;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // googlePlay
            // 
            this.googlePlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.googlePlay.BackColor = System.Drawing.Color.Transparent;
            this.googlePlay.Image = global::Cloud_Storage_App.Properties.Resources.googlePlay_ic;
            this.googlePlay.Location = new System.Drawing.Point(213, 3);
            this.googlePlay.Name = "googlePlay";
            this.googlePlay.Padding = new System.Windows.Forms.Padding(5);
            this.googlePlay.Size = new System.Drawing.Size(75, 72);
            this.googlePlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.googlePlay.TabIndex = 33;
            this.googlePlay.TabStop = false;
            this.googlePlay.Click += new System.EventHandler(this.googlePlay_Click);
            // 
            // miniTable
            // 
            this.miniTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miniTable.ColumnCount = 3;
            this.miniTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.miniTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.miniTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.miniTable.Controls.Add(this.olx, 2, 0);
            this.miniTable.Controls.Add(this.facebook, 0, 0);
            this.miniTable.Controls.Add(this.googlePlay, 1, 0);
            this.miniTable.Location = new System.Drawing.Point(3, 227);
            this.miniTable.Name = "miniTable";
            this.miniTable.RowCount = 1;
            this.miniTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.miniTable.Size = new System.Drawing.Size(501, 78);
            this.miniTable.TabIndex = 34;
            // 
            // olx
            // 
            this.olx.BackColor = System.Drawing.Color.Transparent;
            this.olx.Image = global::Cloud_Storage_App.Properties.Resources.olx_ic;
            this.olx.Location = new System.Drawing.Point(337, 3);
            this.olx.Name = "olx";
            this.olx.Padding = new System.Windows.Forms.Padding(5);
            this.olx.Size = new System.Drawing.Size(75, 72);
            this.olx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.olx.TabIndex = 34;
            this.olx.TabStop = false;
            this.olx.Click += new System.EventHandler(this.olx_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Controls.Add(this.signature, 0, 0);
            this.table.Controls.Add(this.miniTable, 0, 2);
            this.table.Controls.Add(this.credits_lbl, 0, 1);
            this.table.Controls.Add(this.close_btn, 0, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.61067F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.11577F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.05576F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2178F));
            this.table.Size = new System.Drawing.Size(507, 353);
            this.table.TabIndex = 35;
            // 
            // CreditsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.background_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 353);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditsWindow";
            this.Text = "Credits Cloud Storage App";
            ((System.ComponentModel.ISupportInitialize)(this.signature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.googlePlay)).EndInit();
            this.miniTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olx)).EndInit();
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox signature;
        private Bunifu.Framework.UI.BunifuCustomLabel credits_lbl;
        private ePOSOne.btnProduct.Button_WOC close_btn;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox googlePlay;
        private System.Windows.Forms.TableLayoutPanel miniTable;
        private System.Windows.Forms.PictureBox olx;
        private System.Windows.Forms.TableLayoutPanel table;
    }
}