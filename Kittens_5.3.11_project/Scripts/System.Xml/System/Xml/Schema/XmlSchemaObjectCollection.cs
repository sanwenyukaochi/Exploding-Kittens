using System.Collections;

namespace System.Xml.Schema
{
	public class XmlSchemaObjectCollection : CollectionBase
	{
		private XmlSchemaObject parent;

		public virtual XmlSchemaObject this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new XmlSchemaObjectEnumerator GetEnumerator()
		{
			return null;
		}

		public int Add(XmlSchemaObject item)
		{
			return 0;
		}

		public void Insert(int index, XmlSchemaObject item)
		{
		}

		public void Remove(XmlSchemaObject item)
		{
		}

		protected override void OnInsert(int index, object item)
		{
		}

		protected override void OnSet(int index, object oldValue, object newValue)
		{
		}

		protected override void OnClear()
		{
		}

		protected override void OnRemove(int index, object item)
		{
		}

		internal XmlSchemaObjectCollection Clone()
		{
			return null;
		}

		private void Add(XmlSchemaObjectCollection collToAdd)
		{
		}
	}
}
