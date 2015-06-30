using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BZCLauncher.Forms;

namespace BZCLauncher {
	public partial class MainWindow : Form {
		public IConfig @Config { get; }
		public MainWindow() {
			Config = new ConfigManager();
			InitializeComponent();
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

		private void MainWindow_Load(object sender, EventArgs e) {
			this.Hide();
			using (var main = new PageMain(this)) {
				main.ShowDialog();
			}
			this.Close();
		}

		private void PageMain_Load(object sender, EventArgs e) {
		}
	}
}
