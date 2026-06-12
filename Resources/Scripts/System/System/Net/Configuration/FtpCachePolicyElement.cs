using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	public sealed class FtpCachePolicyElement : ConfigurationElement
	{
		public RequestCacheLevel PolicyLevel
		{
			get
			{
				return default(RequestCacheLevel);
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
