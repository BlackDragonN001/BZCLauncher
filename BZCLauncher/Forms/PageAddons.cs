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
	public partial class PageAddons : Form {
		public PageMain @MainWindow { get; set; }
		public PageAddons(PageMain mainWindow) {
			this.MainWindow = mainWindow;
			this.InitializeComponent();
		}

		private void BackButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void LaunchButton_Click(object sender, EventArgs e) {
			Close();
			MainWindow.LaunchGame();
		}

		private void Enable_Click(object sender, EventArgs e) {

		}

		private void Install_Click(object sender, EventArgs e) {

		}
	}
}
