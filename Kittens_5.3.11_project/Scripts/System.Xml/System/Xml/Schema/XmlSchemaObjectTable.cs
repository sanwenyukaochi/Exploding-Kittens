using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	public class XmlSchemaObjectTable
	{
		internal enum EnumeratorType
		{
			Keys = 0,
			Values = 1,
			DictionaryEntry = 2
		}

		internal struct XmlSchemaObjectEntry
		{
			internal XmlQualifiedName qname;

			internal XmlSchemaObject xso;

			public XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value)
			{
				qname = null;
				xso = null;
			}
		}

		internal class ValuesCollection : ICollection, IEnumerable
		{
			private List<XmlSchemaObjectEntry> entries;

			private int size;

			public int Count => 0;

			public object SyncRoot => null;

			public bool IsSynchronized => false;

			internal ValuesCollection(List<XmlSchemaObjectEntry> entries, int size)
			{
			}

			public void CopyTo(Array array, int arrayIndex)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		internal class XSOEnumerator : IEnumerator
		{
			private List<XmlSchemaObjectEntry> entries;

			private EnumeratorType enumType;

			protected int currentIndex;

			protected int size;

			protected XmlQualifiedName currentKey;

			protected XmlSchemaObject currentValue;

			public object Current => null;

			internal XSOEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		internal class XSODictionaryEnumerator : XSOEnumerator, IDictionaryEnumerator, IEnumerator
		{
			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Key => null;

			public object Value => null;

			internal XSODictionaryEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType)
				: base(null, 0, default(EnumeratorType))
			{
			}
		}

		private Dictionary<XmlQualifiedName, XmlSchemaObject> table;

		private List<XmlSchemaObjectEntry> entries;

		public int Count => 0;

		public XmlSchemaObject this[XmlQualifiedName name] => null;

		public ICollection Values => null;

		internal XmlSchemaObjectTable()
		{
		}

		internal void Add(XmlQualifiedName name, XmlSchemaObject value)
		{
		}

		internal void Insert(XmlQualifiedName name, XmlSchemaObject value)
		{
		}

		internal void Replace(XmlQualifiedName name, XmlSchemaObject value)
		{
		}

		internal void Clear()
		{
		}

		internal void Remove(XmlQualifiedName name)
		{
		}

		private int FindIndexByValue(XmlSchemaObject xso)
		{
			return 0;
		}

		public bool Contains(XmlQualifiedName name)
		{
			return false;
		}

		public IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
