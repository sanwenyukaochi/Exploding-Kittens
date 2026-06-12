using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		public int AutoConfigUrlRetryInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TimeSpan DownloadTimeout
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		protected override void PostDeserialize()
		{
		}
	}
}
