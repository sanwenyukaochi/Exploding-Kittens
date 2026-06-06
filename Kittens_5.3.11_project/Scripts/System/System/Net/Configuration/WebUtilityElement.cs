using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class WebUtilityElement : ConfigurationElement
	{
		protected override ConfigurationPropertyCollection Properties => null;

		public UnicodeDecodingConformance UnicodeDecodingConformance
		{
			get
			{
				return default(UnicodeDecodingConformance);
			}
			set
			{
			}
		}

		public UnicodeEncodingConformance UnicodeEncodingConformance
		{
			get
			{
				return default(UnicodeEncodingConformance);
			}
			set
			{
			}
		}
	}
}
