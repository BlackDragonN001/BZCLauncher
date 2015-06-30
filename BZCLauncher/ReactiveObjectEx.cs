using ReactiveUI;

namespace BZCLauncher {
	public class ReactiveObjectEx : ReactiveObject {
		protected void OnPropertyChanged(string propertyName) {
			this.RaisePropertyChanged(propertyName);
		}
	}
}
