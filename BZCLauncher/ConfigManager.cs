using System;

namespace BZCLauncher {
	public class ConfigManager : IConfig {
		public bool Windowed { get; set; }
		public string AdditionalArgs { get; set; }
	}
}
