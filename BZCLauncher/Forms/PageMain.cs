using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZCLauncher.Forms {
	public partial class PageMain : Form {
		public MainWindow @MainWindow { get; set; }
		public PageMain(MainWindow mainWindow) {
			this.MainWindow = mainWindow;
			this.InitializeComponent();
		}

		private void PageMain_Load(object sender, EventArgs e) {

		}

		private void ButtonExit_Click(object sender, EventArgs e) {
			Close();
		}

		private void ButtonAddons_Click(object sender, EventArgs e) {
			this.Close();
			new PageAddons(MainWindow).Show();
		}

		private void LaunchButton_Click(object sender, EventArgs e) {
			this.MainWindow.LaunchGame();
		}

		private void ConfigButton_Click(object sender, EventArgs e) {
			this.Close();
			new PageConfig(MainWindow, MainWindow.Config).Show();
		}
	}
}
