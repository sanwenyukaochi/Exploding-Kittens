using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	public class XmlAttributeOverrides
	{
		private Hashtable overrides;

		public XmlAttributes this[Type type] => null;

		public XmlAttributes this[Type type, string member] => null;

		private TypeMember GetKey(Type type, string member)
		{
			return null;
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
