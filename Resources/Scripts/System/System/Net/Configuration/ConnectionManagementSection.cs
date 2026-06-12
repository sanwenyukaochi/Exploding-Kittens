using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		public ConnectionManagementElementCollection ConnectionManagement => null;

		protected override ConfigurationPropertyCollection Properties => null;
	}
}
