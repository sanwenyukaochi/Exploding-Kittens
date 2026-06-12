using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class Ipv6Element : ConfigurationElement
	{
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

		protected override ConfigurationPropertyCollection Properties => null;
	}
}
