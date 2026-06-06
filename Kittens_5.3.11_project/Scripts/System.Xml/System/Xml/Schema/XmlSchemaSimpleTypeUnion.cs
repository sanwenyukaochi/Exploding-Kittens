using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
	{
		private XmlSchemaObjectCollection baseTypes;

		private XmlQualifiedName[] memberTypes;

		private XmlSchemaSimpleType[] baseMemberTypes;

		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaObjectCollection BaseTypes => null;

		[XmlAttribute("memberTypes")]
		public XmlQualifiedName[] MemberTypes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlSchemaSimpleType[] BaseMemberTypes => null;

		internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes)
		{
		}

		internal override XmlSchemaObject Clone()
		{
			return null;
		}
	}
}
