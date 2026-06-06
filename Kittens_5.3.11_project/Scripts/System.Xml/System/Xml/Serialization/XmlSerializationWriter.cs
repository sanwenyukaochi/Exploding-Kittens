using System.Collections;
using System.Runtime.Serialization;

namespace System.Xml.Serialization
{
	public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode
	{
		private class WriteCallbackInfo
		{
			public Type Type;

			public string TypeName;

			public string TypeNs;

			public XmlSerializationWriteCallback Callback;
		}

		private ObjectIDGenerator idGenerator;

		private int qnameCount;

		private bool topLevelElement;

		private ArrayList namespaces;

		private XmlWriter writer;

		private Queue referencedElements;

		private Hashtable callbacks;

		private Hashtable serializedObjects;

		protected XmlWriter Writer => null;

		internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss)
		{
		}

		protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback)
		{
		}

		protected Exception CreateUnknownAnyElementException(string name, string ns)
		{
			return null;
		}

		protected Exception CreateUnknownTypeException(object o)
		{
			return null;
		}

		protected Exception CreateUnknownTypeException(Type type)
		{
			return null;
		}

		protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName)
		{
			return null;
		}

		private string GetId(object o, bool addToReferencesList)
		{
			return null;
		}

		private bool AlreadyQueued(object ob)
		{
			return false;
		}

		private string GetNamespacePrefix(string ns)
		{
			return null;
		}

		private string GetQualifiedName(string name, string ns)
		{
			return null;
		}

		protected abstract void InitCallbacks();

		protected void TopLevelElement()
		{
		}

		protected void WriteAttribute(string localName, string ns, string value)
		{
		}

		protected void WriteAttribute(string prefix, string localName, string ns, string value)
		{
		}

		private void WriteXmlNode(XmlNode node)
		{
		}

		protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
		}

		protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
		}

		protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value)
		{
		}

		protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
		}

		protected void WriteElementString(string localName, string ns, string value)
		{
		}

		protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType)
		{
		}

		protected void WriteEndElement()
		{
		}

		protected void WriteEndElement(object o)
		{
		}

		protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns)
		{
		}

		protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
		}

		protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value)
		{
		}

		protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType)
		{
		}

		protected void WriteNullableStringLiteral(string name, string ns, string value)
		{
		}

		protected void WriteNullTagEncoded(string name, string ns)
		{
		}

		protected void WriteNullTagLiteral(string name, string ns)
		{
		}

		protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable)
		{
		}

		protected void WriteReferencedElements()
		{
		}

		private bool IsPrimitiveArray(TypeData td)
		{
			return false;
		}

		private void WriteArray(object o, TypeData td)
		{
		}

		protected void WriteReferencingElement(string n, string ns, object o, bool isNullable)
		{
		}

		private void CheckReferenceQueue()
		{
		}

		protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable)
		{
		}

		protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped)
		{
		}

		protected void WriteStartDocument()
		{
		}

		protected void WriteStartElement(string name, string ns)
		{
		}

		protected void WriteStartElement(string name, string ns, bool writePrefixed)
		{
		}

		protected void WriteStartElement(string name, string ns, object o)
		{
		}

		protected void WriteStartElement(string name, string ns, object o, bool writePrefixed)
		{
		}

		private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces)
		{
		}

		protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType)
		{
		}

		protected void WriteValue(string value)
		{
		}

		protected void WriteXmlAttribute(XmlNode node, object container)
		{
		}

		protected void WriteXsiType(string name, string ns)
		{
		}
	}
}
