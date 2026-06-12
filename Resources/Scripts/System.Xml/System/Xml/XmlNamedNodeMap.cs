using System.Collections;

namespace System.Xml
{
	public class XmlNamedNodeMap : IEnumerable
	{
		internal struct SmallXmlNodeList
		{
			private class SingleObjectEnumerator : IEnumerator
			{
				private object loneValue;

				private int position;

				public object Current => null;

				public SingleObjectEnumerator(object value)
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

			private object field;

			public int Count => 0;

			public object this[int index] => null;

			public void Add(object value)
			{
			}

			public void RemoveAt(int index)
			{
			}

			public void Insert(int index, object value)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		internal XmlNode parent;

		internal SmallXmlNodeList nodes;

		public virtual int Count => 0;

		internal XmlNamedNodeMap(XmlNode parent)
		{
		}

		public virtual XmlNode GetNamedItem(string name)
		{
			return null;
		}

		public virtual XmlNode SetNamedItem(XmlNode node)
		{
			return null;
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		internal int FindNodeOffset(string name)
		{
			return 0;
		}

		internal int FindNodeOffset(string localName, string namespaceURI)
		{
			return 0;
		}

		internal virtual XmlNode AddNode(XmlNode node)
		{
			return null;
		}

		internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			return null;
		}

		internal virtual XmlNode RemoveNodeAt(int i)
		{
			return null;
		}

		internal XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			return null;
		}

		internal virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			return null;
		}
	}
}
