using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class BypassElement : ConfigurationElement
	{
		public string Address
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		public BypassElement()
		{
		}

		public BypassElement(string address)
		{
		}
	}
}
