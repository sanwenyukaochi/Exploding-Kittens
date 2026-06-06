using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaRedefine : XmlSchemaExternal
	{
		private XmlSchemaObjectCollection items;

		private XmlSchemaObjectTable attributeGroups;

		private XmlSchemaObjectTable types;

		private XmlSchemaObjectTable groups;

		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		[XmlElement("complexType", typeof(XmlSchemaComplexType))]
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		[XmlElement("group", typeof(XmlSchemaGroup))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
		public XmlSchemaObjectCollection Items => null;

		[XmlIgnore]
		public XmlSchemaObjectTable AttributeGroups => null;

		[XmlIgnore]
		public XmlSchemaObjectTable SchemaTypes => null;

		[XmlIgnore]
		public XmlSchemaObjectTable Groups => null;

		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
		}
	}
}
