using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		public int MaximumErrorResponseLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaximumResponseHeadersLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaximumUnauthorizedUploadLength
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

		public bool UseUnsafeHeaderParsing
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
