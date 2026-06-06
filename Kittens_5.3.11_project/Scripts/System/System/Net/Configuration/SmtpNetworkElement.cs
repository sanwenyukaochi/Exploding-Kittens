using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class SmtpNetworkElement : ConfigurationElement
	{
		public string ClientDomain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool DefaultCredentials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableSsl
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Host
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Port
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		public string TargetName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void PostDeserialize()
		{
		}
	}
}
