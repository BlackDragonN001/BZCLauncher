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
		public IConfig @Config { get; }
		public PageMain() {
			Config = new ConfigManager();
			this.InitializeComponent();
		}

		private void PageMain_Load(object sender, EventArgs e) {

		}

		private void ButtonExit_Click(object sender, EventArgs e) {
			Close();
		}

		private void ButtonAddons_Click(object sender, EventArgs e) {
			this.Hide();
			using (var pageAddons = new PageAddons(this)) {
				pageAddons.ShowDialog();
			}
			this.Show();
		}

		private void LaunchButton_Click(object sender, EventArgs e) {
			LaunchGame();
		}

		private void ConfigButton_Click(object sender, EventArgs e) {
			this.Hide();
			using (var pageConfig = new PageConfig(this, Config)) {
				pageConfig.ShowDialog();
			}
			this.Show();
		}

		public void LaunchGame() {
			string commandArguments = Config.BuildCommandArguments();

			try {
				//Form.ActiveForm.Hide();
				//Form.ActiveForm.Show();

				//MainWindow newWindow = new MainWindow();
				//newWindow.Show();

				System.Diagnostics.Process resultProcess = System.Diagnostics.Process.Start("bzone.exe", "/config BZC_bzone.cfg " + commandArguments);

				// resultProcess.WaitForExit();

				//Form.ActiveForm.Visible = true;
			} catch (System.ComponentModel.Win32Exception exception) {
				MessageBox.Show("An internal exception occurred trying to run BattleZone: " + exception.Message, "Error");
			}

			this.Close();
		}
	}
}
