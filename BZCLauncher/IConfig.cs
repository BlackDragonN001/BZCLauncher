using System;
using System.ComponentModel;
using System.Reactive;
using System.Text;

namespace BZCLauncher {
	public static class ConfigX {
		public static string BuildCommandArguments(this IConfig config) {
			var args = new StringBuilder();
			if (config.Windowed) {
				args.Append(" /win");
			}
			if (!String.IsNullOrWhiteSpace(config.AdditionalArgs)) {
				args.AppendFormat(" {0}", config.AdditionalArgs);
			}
			return args.ToString().Trim();
		}
	}
	public interface IConfig : INotifyPropertyChanged {
		bool Windowed { get; set; }
		string AdditionalArgs { get; set; }
		IObservable<Unit> UponChanged { get; }
	}
}
