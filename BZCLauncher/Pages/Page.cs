using System.Windows.Forms;

namespace BZCLauncher
{
	/// <summary>
	/// Abstract base class for pages.
	/// </summary>
	public abstract class Page : UserControl
	{
		#region Fields

		#endregion

		#region Properties

		public MainWindow MainWindow
		{
			get { return this.ParentForm as MainWindow; }
		}

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new Page.
		/// </summary>
		protected Page()
		{
		
		}

		#endregion

		#region Methods

		#endregion
	}
}
