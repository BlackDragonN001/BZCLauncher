using System;
using System.Text;

namespace BZCLauncher {
	public static class ConfigX {
		public static string BuildCommandArguments(this IConfig config) {
			var args = new StringBuilder();
			if (config.Windowed) {
				args.Append(" /win");
			}
			if (!String.IsNullOrWhiteSpace(config.AdditionalArgs)) {
				args.Append(config.AdditionalArgs);
			}
			return args.ToString();
		}
	}
	public interface IConfig {
		bool Windowed { get; set; }
		string AdditionalArgs { get; set; }
	}
}
