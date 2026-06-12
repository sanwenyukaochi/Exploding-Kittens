using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration
{
	public sealed class SmtpSection : ConfigurationSection
	{
		public SmtpDeliveryFormat DeliveryFormat
		{
			get
			{
				return default(SmtpDeliveryFormat);
			}
			set
			{
			}
		}

		public SmtpDeliveryMethod DeliveryMethod
		{
			get
			{
				return default(SmtpDeliveryMethod);
			}
			set
			{
			}
		}

		public string From
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SmtpNetworkElement Network => null;

		protected override ConfigurationPropertyCollection Properties => null;

		public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory => null;
	}
}
