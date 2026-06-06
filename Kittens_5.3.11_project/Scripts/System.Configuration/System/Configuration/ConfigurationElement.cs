using System.Reflection;
using System.Xml;

namespace System.Configuration
{
	[DefaultMember("Item")]
	public abstract class ConfigurationElement
	{
		protected internal virtual ConfigurationPropertyCollection Properties => null;

		protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		protected internal virtual void InitializeDefault()
		{
		}

		protected internal virtual bool IsModified()
		{
			return false;
		}

		protected virtual void PostDeserialize()
		{
		}

		protected internal virtual void Reset(ConfigurationElement parentElement)
		{
		}

		protected internal virtual void ResetModified()
		{
		}
	}
}
