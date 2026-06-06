using System.Collections;

namespace System.Xml.Serialization
{
	[System.MonoTODO]
	public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
	{
		private class WriteCallbackInfo
		{
			public Type Type;

			public string TypeName;

			public string TypeNs;

			public XmlSerializationReadCallback Callback;
		}

		protected class CollectionFixup
		{
			private XmlSerializationCollectionFixupCallback callback;

			private object collection;

			private object collectionItems;

			private string id;

			public XmlSerializationCollectionFixupCallback Callback => null;

			public object Collection => null;

			internal object Id => null;

			public object CollectionItems
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			internal CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, string id)
			{
			}
		}

		protected class Fixup
		{
			private object source;

			private string[] ids;

			private XmlSerializationFixupCallback callback;

			public XmlSerializationFixupCallback Callback => null;

			public string[] Ids => null;

			public object Source => null;

			public Fixup(object o, XmlSerializationFixupCallback callback, int count)
			{
			}
		}

		private class CollectionItemFixup
		{
			private Array list;

			private int index;

			private string id;

			public Array Collection => null;

			public int Index => 0;

			public string Id => null;

			public CollectionItemFixup(Array list, int index, string id)
			{
			}
		}

		private XmlDocument document;

		private XmlReader reader;

		private ArrayList fixups;

		private Hashtable collFixups;

		private ArrayList collItemFixups;

		private Hashtable typesCallbacks;

		private ArrayList noIDTargets;

		private Hashtable targets;

		private Hashtable delayedListFixups;

		private XmlSerializer eventSource;

		private int delayedFixupId;

		private Hashtable referencedObjects;

		private int readCount;

		private int whileIterationCount;

		private string w3SchemaNS;

		private string w3InstanceNS;

		private string w3InstanceNS2000;

		private string w3InstanceNS1999;

		private string soapNS;

		private string wsdlNS;

		private string nullX;

		private string nil;

		private string typeX;

		private string arrayType;

		private XmlQualifiedName arrayQName;

		protected XmlDocument Document => null;

		protected XmlReader Reader => null;

		internal void Initialize(XmlReader reader, XmlSerializer eventSource)
		{
		}

		private ArrayList EnsureArrayList(ArrayList list)
		{
			return null;
		}

		private Hashtable EnsureHashtable(Hashtable hash)
		{
			return null;
		}

		protected void AddFixup(CollectionFixup fixup)
		{
		}

		protected void AddFixup(Fixup fixup)
		{
		}

		private void AddFixup(CollectionItemFixup fixup)
		{
		}

		protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read)
		{
		}

		protected void AddTarget(string id, object o)
		{
		}

		private string CurrentTag()
		{
			return null;
		}

		protected Exception CreateReadOnlyCollectionException(string name)
		{
			return null;
		}

		protected Exception CreateUnknownConstantException(string value, Type enumType)
		{
			return null;
		}

		protected Exception CreateUnknownNodeException()
		{
			return null;
		}

		protected Exception CreateUnknownTypeException(XmlQualifiedName type)
		{
			return null;
		}

		protected Array EnsureArrayIndex(Array a, int index, Type elementType)
		{
			return null;
		}

		protected bool GetNullAttr()
		{
			return false;
		}

		protected object GetTarget(string id)
		{
			return null;
		}

		private bool TargetReady(string id)
		{
			return false;
		}

		protected XmlQualifiedName GetXsiType()
		{
			return null;
		}

		protected abstract void InitCallbacks();

		protected abstract void InitIDs();

		protected bool IsXmlnsAttribute(string name)
		{
			return false;
		}

		protected void ParseWsdlArrayType(XmlAttribute attr)
		{
		}

		protected XmlQualifiedName ReadElementQualifiedName()
		{
			return null;
		}

		protected void ReadEndElement()
		{
		}

		protected bool ReadNull()
		{
			return false;
		}

		protected XmlQualifiedName ReadNullableQualifiedName()
		{
			return null;
		}

		protected string ReadNullableString()
		{
			return null;
		}

		protected object ReadReferencedElement()
		{
			return null;
		}

		private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname)
		{
			return null;
		}

		protected object ReadReferencedElement(string name, string ns)
		{
			return null;
		}

		private bool ReadList(out object resultList)
		{
			resultList = null;
			return false;
		}

		protected void ReadReferencedElements()
		{
		}

		protected object ReadReferencingElement(out string fixupReference)
		{
			fixupReference = null;
			return null;
		}

		protected object ReadReferencingElement(string name, string ns, out string fixupReference)
		{
			fixupReference = null;
			return null;
		}

		protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference)
		{
			fixupReference = null;
			return null;
		}

		protected IXmlSerializable ReadSerializable(IXmlSerializable serializable)
		{
			return null;
		}

		protected object ReadTypedPrimitive(XmlQualifiedName type)
		{
			return null;
		}

		private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown)
		{
			return null;
		}

		protected XmlNode ReadXmlNode(bool wrapped)
		{
			return null;
		}

		protected XmlDocument ReadXmlDocument(bool wrapped)
		{
			return null;
		}

		protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable)
		{
			return null;
		}

		protected XmlQualifiedName ToXmlQualifiedName(string value)
		{
			return null;
		}

		protected void UnknownAttribute(object o, XmlAttribute attr, string qnames)
		{
		}

		protected void UnknownElement(object o, XmlElement elem, string qnames)
		{
		}

		protected void UnknownNode(object o)
		{
		}

		protected void UnknownNode(object o, string qnames)
		{
		}

		private void OnUnknownNode(XmlNode node, object o, string qnames)
		{
		}

		protected void UnreferencedObject(string id, object o)
		{
		}
	}
}
