using System.Collections;
using System.IO;
using System.Reflection;

namespace System.Xml.Serialization
{
	public class XmlSerializer
	{
		internal class SerializerData
		{
			public MethodInfo ReaderMethod;

			public Type WriterType;

			public MethodInfo WriterMethod;

			public XmlSerializerImplementation Implementation;

			public XmlSerializationWriter CreateWriter()
			{
				return null;
			}
		}

		private static int generationThreshold;

		private static bool backgroundGeneration;

		private static bool deleteTempFiles;

		private static bool generatorFallback;

		private bool customSerializer;

		private XmlMapping typeMapping;

		private SerializerData serializerData;

		private static Hashtable serializerTypes;

		private UnreferencedObjectEventHandler onUnreferencedObject;

		private XmlAttributeEventHandler onUnknownAttribute;

		private XmlElementEventHandler onUnknownElement;

		private XmlNodeEventHandler onUnknownNode;

		internal XmlMapping Mapping => null;

		static XmlSerializer()
		{
		}

		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
		}

		internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e)
		{
		}

		internal virtual void OnUnknownElement(XmlElementEventArgs e)
		{
		}

		internal virtual void OnUnknownNode(XmlNodeEventArgs e)
		{
		}

		internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e)
		{
		}

		protected virtual XmlSerializationReader CreateReader()
		{
			return null;
		}

		protected virtual XmlSerializationWriter CreateWriter()
		{
			return null;
		}

		public object Deserialize(TextReader textReader)
		{
			return null;
		}

		public object Deserialize(XmlReader xmlReader)
		{
			return null;
		}

		protected virtual object Deserialize(XmlSerializationReader reader)
		{
			return null;
		}

		protected virtual void Serialize(object o, XmlSerializationWriter writer)
		{
		}

		public void Serialize(TextWriter textWriter, object o)
		{
		}

		public void Serialize(XmlWriter xmlWriter, object o)
		{
		}

		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces)
		{
		}

		private XmlSerializationWriter CreateWriter(XmlMapping typeMapping)
		{
			return null;
		}

		private XmlSerializationReader CreateReader(XmlMapping typeMapping)
		{
			return null;
		}
	}
}
