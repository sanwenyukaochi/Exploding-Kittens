using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class DefaultProxySection : ConfigurationSection
	{
		public BypassElementCollection BypassList => null;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ModuleElement Module => null;

		protected override ConfigurationPropertyCollection Properties => null;

		public ProxyElement Proxy => null;

		public bool UseDefaultCredentials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void PostDeserialize()
		{
		}

		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
