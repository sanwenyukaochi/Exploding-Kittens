using System.Configuration;
using System.Net.Security;

namespace System.Net.Configuration
{
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		public bool CheckCertificateName
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckCertificateRevocationList
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int DnsRefreshTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool EnableDnsRoundRobin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public EncryptionPolicy EncryptionPolicy
		{
			get
			{
				return default(EncryptionPolicy);
			}
			set
			{
			}
		}

		public bool Expect100Continue
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

		public bool UseNagleAlgorithm
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
	}
}
