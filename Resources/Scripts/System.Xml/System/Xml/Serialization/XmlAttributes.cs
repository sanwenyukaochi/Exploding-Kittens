using System.Reflection;
using System.Text;

namespace System.Xml.Serialization
{
	public class XmlAttributes
	{
		private XmlAnyAttributeAttribute xmlAnyAttribute;

		private XmlAnyElementAttributes xmlAnyElements;

		private XmlArrayAttribute xmlArray;

		private XmlArrayItemAttributes xmlArrayItems;

		private XmlAttributeAttribute xmlAttribute;

		private XmlChoiceIdentifierAttribute xmlChoiceIdentifier;

		private object xmlDefaultValue;

		private XmlElementAttributes xmlElements;

		private XmlEnumAttribute xmlEnum;

		private bool xmlIgnore;

		private bool xmlns;

		private XmlRootAttribute xmlRoot;

		private XmlTextAttribute xmlText;

		private XmlTypeAttribute xmlType;

		public XmlAnyAttributeAttribute XmlAnyAttribute => null;

		public XmlAnyElementAttributes XmlAnyElements => null;

		public XmlArrayAttribute XmlArray => null;

		public XmlArrayItemAttributes XmlArrayItems => null;

		public XmlAttributeAttribute XmlAttribute => null;

		public XmlChoiceIdentifierAttribute XmlChoiceIdentifier => null;

		public object XmlDefaultValue => null;

		public XmlElementAttributes XmlElements => null;

		public bool XmlIgnore => false;

		public bool Xmlns => false;

		public XmlRootAttribute XmlRoot => null;

		public XmlTextAttribute XmlText => null;

		public XmlTypeAttribute XmlType => null;

		internal int? Order => null;

		internal int SortableOrder => 0;

		public XmlAttributes()
		{
		}

		public XmlAttributes(ICustomAttributeProvider provider)
		{
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
