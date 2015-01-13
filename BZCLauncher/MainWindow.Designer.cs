namespace BZCLauncher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PageMain = new BZCLauncher.PageMain();
            this.PageAddons = new BZCLauncher.PageAddons();
            this.PageConfig = new BZCLauncher.Pages.PageConfig();
            this.SuspendLayout();
            // 
            // PageMain
            // 
            this.PageMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageMain.BackgroundImage")));
            this.PageMain.Location = new System.Drawing.Point(0, 0);
            this.PageMain.Name = "PageMain";
            this.PageMain.Size = new System.Drawing.Size(640, 480);
            this.PageMain.TabIndex = 1;
            this.PageMain.Load += new System.EventHandler(this.PageMain_Load);
            // 
            // PageAddons
            // 
            this.PageAddons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageAddons.BackgroundImage")));
            this.PageAddons.Location = new System.Drawing.Point(0, 0);
            this.PageAddons.Name = "PageAddons";
            this.PageAddons.Size = new System.Drawing.Size(640, 525);
            this.PageAddons.TabIndex = 0;
            // 
            // pageConfig1
            // 
            this.PageConfig.Location = new System.Drawing.Point(0, 0);
            this.PageConfig.Name = "PageConfig";
            this.PageConfig.Size = new System.Drawing.Size(640, 480);
            this.PageConfig.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 480);
            this.Controls.Add(this.PageConfig);
            this.Controls.Add(this.PageMain);
            this.Controls.Add(this.PageAddons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(659, 522);
            this.MinimumSize = new System.Drawing.Size(659, 522);
            this.Name = "MainWindow";
            this.Text = "BattleZone: Classic Launcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public PageAddons PageAddons;
        public PageMain PageMain;
        public Pages.PageConfig PageConfig;


    }
}

