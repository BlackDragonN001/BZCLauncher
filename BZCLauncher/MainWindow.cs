using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZCLauncher
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void LaunchGame()
		{
			MainWindow activeForm = (MainWindow)Form.ActiveForm;
			string commandArguments = activeForm.Config.ConfigParameter.Text;

			try
			{
				//Form.ActiveForm.Hide();
				//Form.ActiveForm.Show();

				//MainWindow newWindow = new MainWindow();
				//newWindow.Show();

				System.Diagnostics.Process resultProcess = System.Diagnostics.Process.Start("bzone.exe", "/config BZC_bzone.cfg " + commandArguments);

				// resultProcess.WaitForExit();

				//Form.ActiveForm.Visible = true;
			}
			catch (System.ComponentModel.Win32Exception exception)
			{
				MessageBox.Show("An internal exception occurred trying to run BattleZone: " + exception.Message, "Error");
			}

			activeForm.Close();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			Main.Visible = true;
			Addons.Visible = false;
			Config.Visible = false;
		}

		private void PageMain_Load(object sender, EventArgs e)
		{

		}

		public void ShowPage(string name)
		{
			foreach (Control control in this.Controls)
			{
				control.Visible = control.Name == name;
			}
		}
	}
}
