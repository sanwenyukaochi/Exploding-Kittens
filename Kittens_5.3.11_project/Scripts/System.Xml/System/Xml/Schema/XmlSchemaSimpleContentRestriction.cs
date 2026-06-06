using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
	{
		private XmlQualifiedName baseTypeName;

		private XmlSchemaSimpleType baseType;

		private XmlSchemaObjectCollection facets;

		private XmlSchemaObjectCollection attributes;

		private XmlSchemaAnyAttribute anyAttribute;

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

		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType BaseType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
		[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
		[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
		[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
		[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
		[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
		[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
		[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
		[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
		[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
		[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
		[XmlElement("length", typeof(XmlSchemaLengthFacet))]
		public XmlSchemaObjectCollection Facets => null;

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
