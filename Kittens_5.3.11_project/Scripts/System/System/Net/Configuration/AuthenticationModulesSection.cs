using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class AuthenticationModulesSection : ConfigurationSection
	{
		public AuthenticationModuleElementCollection AuthenticationModules => null;

		protected override ConfigurationPropertyCollection Properties => null;

		protected override void InitializeDefault()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
