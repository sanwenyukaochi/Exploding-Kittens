using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		private XmlQualifiedName itemTypeName;

		private XmlSchemaSimpleType itemType;

		private XmlSchemaSimpleType baseItemType;

		[XmlAttribute("itemType")]
		public XmlQualifiedName ItemTypeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType ItemType
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
		public XmlSchemaSimpleType BaseItemType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal override XmlSchemaObject Clone()
		{
			return null;
		}
	}
}
