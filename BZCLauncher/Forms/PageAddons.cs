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
		public MainWindow @MainWindow { get; set; }
		public PageAddons(MainWindow mainWindow) {
			this.MainWindow = mainWindow;
			this.InitializeComponent();
		}

		private void BackButton_Click(object sender, EventArgs e) {
			this.Close();
			new PageMain(MainWindow).Show();
		}

		private void LaunchButton_Click(object sender, EventArgs e) {
			MainWindow.LaunchGame();
		}

		private void Enable_Click(object sender, EventArgs e) {

		}

		private void Install_Click(object sender, EventArgs e) {

		}
	}
}
