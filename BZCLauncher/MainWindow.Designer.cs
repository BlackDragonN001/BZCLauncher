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
			this.Config = new BZCLauncher.Pages.PageConfig();
			this.Main = new BZCLauncher.PageMain();
			this.Addons = new BZCLauncher.PageAddons();
			this.SuspendLayout();
			// 
			// Config
			// 
			this.Config.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Config.BackgroundImage")));
			this.Config.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Config.Location = new System.Drawing.Point(0, 0);
			this.Config.Name = "Config";
			this.Config.Size = new System.Drawing.Size(639, 480);
			this.Config.TabIndex = 2;
			// 
			// Main
			// 
			this.Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Main.BackgroundImage")));
			this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main.Location = new System.Drawing.Point(0, 0);
			this.Main.Name = "Main";
			this.Main.Size = new System.Drawing.Size(639, 480);
			this.Main.TabIndex = 1;
			this.Main.Load += new System.EventHandler(this.PageMain_Load);
			// 
			// Addons
			// 
			this.Addons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Addons.BackgroundImage")));
			this.Addons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Addons.Location = new System.Drawing.Point(0, 0);
			this.Addons.Name = "Addons";
			this.Addons.Size = new System.Drawing.Size(639, 480);
			this.Addons.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 480);
			this.Controls.Add(this.Config);
			this.Controls.Add(this.Main);
			this.Controls.Add(this.Addons);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximumSize = new System.Drawing.Size(659, 522);
			this.MinimumSize = new System.Drawing.Size(659, 522);
			this.Name = "MainWindow";
			this.Text = "BattleZone: Classic Launcher";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public PageAddons Addons;
		public PageMain Main;
		public Pages.PageConfig Config;


	}
}

