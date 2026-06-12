using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	public class XmlAnyElementAttributes : CollectionBase
	{
		public XmlAnyElementAttribute this[int index] => null;

		internal int Order => 0;

		public int Add(XmlAnyElementAttribute attribute)
		{
			return 0;
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
