using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
	{
		public string PickupDirectoryLocation
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
	}
}
