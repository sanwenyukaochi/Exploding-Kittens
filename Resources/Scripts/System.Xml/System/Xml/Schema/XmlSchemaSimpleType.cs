using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		private XmlSchemaSimpleTypeContent content;

		[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
		[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
		[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
		public XmlSchemaSimpleTypeContent Content
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
