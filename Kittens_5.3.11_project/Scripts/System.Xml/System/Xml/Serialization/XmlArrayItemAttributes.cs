using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	public class XmlArrayItemAttributes : CollectionBase
	{
		public XmlArrayItemAttribute this[int index] => null;

		public int Add(XmlArrayItemAttribute attribute)
		{
			return 0;
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
