using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		public TimeSpan MaximumAge
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public TimeSpan MaximumStale
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public TimeSpan MinimumFresh
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public HttpRequestCacheLevel PolicyLevel
		{
			get
			{
				return default(HttpRequestCacheLevel);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
