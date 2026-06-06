using System.Collections;
using System.Threading;

namespace System.Xml.Schema
{
	[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
	public sealed class XmlSchemaCollection : ICollection, IEnumerable
	{
		private Hashtable collection;

		private XmlNameTable nameTable;

		private SchemaNames schemaNames;

		private ReaderWriterLock wLock;

		private int timeout;

		private bool isThreadSafe;

		private ValidationEventHandler validationEventHandler;

		private XmlResolver xmlResolver;

		public int Count => 0;

		public XmlNameTable NameTable => null;

		internal XmlResolver XmlResolver
		{
			set
			{
			}
		}

		public XmlSchema this[string ns] => null;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		int ICollection.Count => 0;

		internal ValidationEventHandler EventHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlSchemaCollection(XmlNameTable nametable)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public XmlSchemaCollectionEnumerator GetEnumerator()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		internal SchemaInfo GetSchemaInfo(string ns)
		{
			return null;
		}

		internal SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			return null;
		}

		internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile)
		{
			return null;
		}

		private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver)
		{
			return null;
		}

		private void Add(string ns, XmlSchemaCollectionNode node)
		{
		}
	}
}
