using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	public sealed class RequestCachingSection : ConfigurationSection
	{
		public FtpCachePolicyElement DefaultFtpCachePolicy => null;

		public HttpCachePolicyElement DefaultHttpCachePolicy => null;

		public RequestCacheLevel DefaultPolicyLevel
		{
			get
			{
				return default(RequestCacheLevel);
			}
			set
			{
			}
		}

		public bool DisableAllCaching
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsPrivateCache
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

		public TimeSpan UnspecifiedMaximumAge
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
