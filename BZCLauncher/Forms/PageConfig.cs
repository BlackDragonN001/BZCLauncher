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
	public partial class PageConfig : Form {
		IConfig config { get; }

		public PageMain @MainWindow { get; set; }

		public PageConfig(PageMain mainWindow, IConfig config) {
			this.MainWindow = mainWindow;
			this.config = config;
			this.InitializeComponent();
		}

		private void BackButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void ConfigParameter_Changed(object sender, EventArgs e) {
			config.AdditionalArgs = ConfigParameter.Text;
		}

		private void CheckWindow_CheckedChanged(object sender, EventArgs e) {
			config.Windowed = CheckWindow.Checked;
		}

		private void LaunchButton_Click(object sender, EventArgs e) {
			Close();
			MainWindow.LaunchGame();
		}
	}
}
