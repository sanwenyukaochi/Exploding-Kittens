using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaSimpleContentExtension : XmlSchemaContent
	{
		private XmlSchemaObjectCollection attributes;

		private XmlSchemaAnyAttribute anyAttribute;

		private XmlQualifiedName baseTypeName;

		[XmlAttribute("base")]
		public XmlQualifiedName BaseTypeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes => null;

		[XmlElement("anyAttribute")]
		public XmlSchemaAnyAttribute AnyAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
		}
	}
}
