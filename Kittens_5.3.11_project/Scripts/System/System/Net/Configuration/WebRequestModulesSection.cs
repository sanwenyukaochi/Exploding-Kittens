using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		protected override ConfigurationPropertyCollection Properties => null;

		public WebRequestModuleElementCollection WebRequestModules => null;

		protected override void InitializeDefault()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
