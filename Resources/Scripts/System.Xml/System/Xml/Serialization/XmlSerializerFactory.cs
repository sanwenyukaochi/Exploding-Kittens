using System.Collections;

namespace System.Xml.Serialization
{
	public class XmlSerializerFactory
	{
		private static Hashtable serializersBySource;

		public XmlSerializer CreateSerializer(Type type)
		{
			return null;
		}

		public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root)
		{
			return null;
		}

		public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}
	}
}
