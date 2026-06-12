using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	public class XmlElementAttributes : CollectionBase
	{
		public XmlElementAttribute this[int index] => null;

		internal int Order => 0;

		public int Add(XmlElementAttribute attribute)
		{
			return 0;
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
