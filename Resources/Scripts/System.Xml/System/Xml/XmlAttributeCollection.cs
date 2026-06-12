using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Xml
{
	public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
	{
		[IndexerName("ItemOf")]
		public XmlAttribute this[int i] => null;

		[IndexerName("ItemOf")]
		public XmlAttribute this[string name] => null;

		[IndexerName("ItemOf")]
		public XmlAttribute this[string localName, string namespaceURI] => null;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		int ICollection.Count => 0;

		internal XmlAttributeCollection(XmlNode parent)
			: base(null)
		{
		}

		internal int FindNodeOffsetNS(XmlAttribute node)
		{
			return 0;
		}

		public override XmlNode SetNamedItem(XmlNode node)
		{
			return null;
		}

		public XmlAttribute Append(XmlAttribute node)
		{
			return null;
		}

		public XmlAttribute Remove(XmlAttribute node)
		{
			return null;
		}

		public XmlAttribute RemoveAt(int i)
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		internal override XmlNode AddNode(XmlNode node)
		{
			return null;
		}

		internal override XmlNode InsertNodeAt(int i, XmlNode node)
		{
			return null;
		}

		internal override XmlNode RemoveNodeAt(int i)
		{
			return null;
		}

		internal void Detach(XmlAttribute attr)
		{
		}

		internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
		{
		}

		internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
		{
		}

		internal int RemoveDuplicateAttribute(XmlAttribute attr)
		{
			return 0;
		}

		internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
		{
			return false;
		}

		internal void ResetParentInElementIdAttrMap(string oldVal, string newVal)
		{
		}

		internal XmlAttribute InternalAppendAttribute(XmlAttribute node)
		{
			return null;
		}
	}
}
