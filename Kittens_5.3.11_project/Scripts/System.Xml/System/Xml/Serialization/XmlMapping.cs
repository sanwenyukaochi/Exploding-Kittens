using System.Collections;

namespace System.Xml.Serialization
{
	public abstract class XmlMapping
	{
		private ObjectMap map;

		private ArrayList relatedMaps;

		private SerializationFormat format;

		private SerializationSource source;

		internal string _elementName;

		internal string _namespace;

		private string key;

		public string ElementName => null;

		public string Namespace => null;

		internal ObjectMap ObjectMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ArrayList RelatedMaps
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal SerializationFormat Format
		{
			get
			{
				return default(SerializationFormat);
			}
			set
			{
			}
		}

		internal SerializationSource Source => null;

		internal XmlMapping(string elementName, string ns)
		{
		}

		public void SetKey(string key)
		{
		}
	}
}
