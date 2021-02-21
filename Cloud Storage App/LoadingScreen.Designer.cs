namespace Cloud_Storage_App
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.pbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.loading_lbl = new System.Windows.Forms.Label();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.animated = false;
            this.pbar.animationIterval = 5;
            this.pbar.animationSpeed = 300;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbar.BackgroundImage")));
            this.pbar.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbar.LabelVisible = true;
            this.pbar.LineProgressThickness = 8;
            this.pbar.LineThickness = 5;
            this.pbar.Location = new System.Drawing.Point(84, 19);
            this.pbar.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pbar.MaxValue = 100;
            this.pbar.Name = "pbar";
            this.pbar.ProgressBackColor = System.Drawing.Color.LightGray;
            this.pbar.ProgressColor = System.Drawing.Color.Coral;
            this.pbar.Size = new System.Drawing.Size(289, 289);
            this.pbar.TabIndex = 0;
            this.pbar.Value = 0;
            // 
            // loading_lbl
            // 
            this.loading_lbl.BackColor = System.Drawing.Color.Transparent;
            this.loading_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loading_lbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loading_lbl.Location = new System.Drawing.Point(0, 334);
            this.loading_lbl.Name = "loading_lbl";
            this.loading_lbl.Size = new System.Drawing.Size(457, 79);
            this.loading_lbl.TabIndex = 1;
            this.loading_lbl.Text = "Loading...";
            this.loading_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 5;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Storage_App.Properties.Resources.yellowBackground_FHD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 413);
            this.Controls.Add(this.loading_lbl);
            this.Controls.Add(this.pbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar pbar;
        private System.Windows.Forms.Label loading_lbl;
        private System.Windows.Forms.Timer loadingTimer;
    }
}