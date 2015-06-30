namespace BZCLauncher.Forms {
    partial class PageAddons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Addon1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Battlezone Classic", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TEST");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("The Red Odyssey", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.BackButton = new BZCLauncher.Controls.PictureButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LaunchButton = new BZCLauncher.Controls.PictureButton();
            this.Install = new BZCLauncher.Controls.PictureButton();
            this.Enable = new BZCLauncher.Controls.PictureButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExpansionSelection = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.DownImage = global::BZCLauncher.Properties.Resources.TLbtnclk;
            this.BackButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Lime;
            this.BackButton.IdleImage = global::BZCLauncher.Properties.Resources.TLbtnoff;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.MousedOverImage = global::BZCLauncher.Properties.Resources.TLbtnon;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(152, 34);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "BACK";
            this.BackButton.TextOffset = new System.Drawing.Point(16, -3);
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BZCLauncher.Properties.Resources.bzctag;
            this.pictureBox1.Location = new System.Drawing.Point(256, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchButton.DownImage = global::BZCLauncher.Properties.Resources.TRbtnclk;
            this.LaunchButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.ForeColor = System.Drawing.Color.Lime;
            this.LaunchButton.IdleImage = global::BZCLauncher.Properties.Resources.TRbtnoff;
            this.LaunchButton.Location = new System.Drawing.Point(488, 0);
            this.LaunchButton.MousedOverImage = global::BZCLauncher.Properties.Resources.TRbtnon;
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(152, 34);
            this.LaunchButton.TabIndex = 5;
            this.LaunchButton.Text = "LAUNCH";
            this.LaunchButton.TextOffset = new System.Drawing.Point(-12, -3);
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // Install
            // 
            this.Install.DownImage = global::BZCLauncher.Properties.Resources.BLbtnclk;
            this.Install.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Install.ForeColor = System.Drawing.Color.Lime;
            this.Install.IdleImage = global::BZCLauncher.Properties.Resources.BLbtnoff;
            this.Install.Location = new System.Drawing.Point(0, 445);
            this.Install.MousedOverImage = global::BZCLauncher.Properties.Resources.BLbtnon;
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(200, 35);
            this.Install.TabIndex = 6;
            this.Install.Text = "INSTALL";
            this.Install.TextOffset = new System.Drawing.Point(-6, 1);
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Enable
            // 
            this.Enable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Enable.BackColor = System.Drawing.SystemColors.Control;
            this.Enable.DownImage = global::BZCLauncher.Properties.Resources.BRbtnclk;
            this.Enable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enable.ForeColor = System.Drawing.Color.Lime;
            this.Enable.IdleImage = global::BZCLauncher.Properties.Resources.BRbtnoff;
            this.Enable.Location = new System.Drawing.Point(440, 445);
            this.Enable.MousedOverImage = global::BZCLauncher.Properties.Resources.BRbtnon;
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(200, 35);
            this.Enable.TabIndex = 7;
            this.Enable.Text = "ENABLE";
            this.Enable.TextOffset = new System.Drawing.Point(12, 1);
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::BZCLauncher.Properties.Resources.smallwindow1;
            this.pictureBox2.Location = new System.Drawing.Point(37, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ExpansionSelection
            // 
            this.ExpansionSelection.FormattingEnabled = true;
            this.ExpansionSelection.Items.AddRange(new object[] {
            "Battlezone Classic",
            "The Red Odyssey",
            "Rise of the Black Dogs"});
            this.ExpansionSelection.Location = new System.Drawing.Point(68, 84);
            this.ExpansionSelection.Name = "ExpansionSelection";
            this.ExpansionSelection.Size = new System.Drawing.Size(169, 160);
            this.ExpansionSelection.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BZCLauncher.Properties.Resources.bigwindow1;
            this.pictureBox3.Location = new System.Drawing.Point(256, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(348, 376);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(92, 250);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Addon1";
            treeNode1.Text = "Addon1";
            treeNode2.Name = "BZC";
            treeNode2.Text = "Battlezone Classic";
            treeNode3.Name = "Test";
            treeNode3.Text = "TEST";
            treeNode4.Name = "TRO";
            treeNode4.Text = "The Red Odyssey";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 11;
            // 
            // PageAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.bzclbackground;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ExpansionSelection);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "PageAddons";
            this.Size = new System.Drawing.Size(640, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PictureButton BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.PictureButton LaunchButton;
        private Controls.PictureButton Install;
        private Controls.PictureButton Enable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox ExpansionSelection;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TreeView treeView1;
    }
}
