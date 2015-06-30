using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;

namespace BZCLauncher {
	public class ConfigManager : ReactiveObjectEx, IConfig {
		public bool Windowed { get; set; }
		public string AdditionalArgs { get; set; }

		public IObservable<Unit> UponChanged {
			get {
				return this.Changed.Select(_ => Unit.Default);
			}
		}
	}
}
