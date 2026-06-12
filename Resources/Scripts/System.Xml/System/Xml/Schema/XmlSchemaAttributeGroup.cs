using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
	{
		private string name;

		private XmlSchemaObjectCollection attributes;

		private XmlSchemaAnyAttribute anyAttribute;

		private XmlQualifiedName qname;

		private XmlSchemaAttributeGroup redefined;

		private XmlSchemaObjectTable attributeUses;

		private XmlSchemaAnyAttribute attributeWildcard;

		private int selfReferenceCount;

		[XmlAttribute("name")]
		public string Name
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

		[XmlIgnore]
		public XmlQualifiedName QualifiedName => null;

		[XmlIgnore]
		internal XmlSchemaObjectTable AttributeUses => null;

		[XmlIgnore]
		internal XmlSchemaAnyAttribute AttributeWildcard
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
		public XmlSchemaAttributeGroup RedefinedAttributeGroup => null;

		[XmlIgnore]
		internal XmlSchemaAttributeGroup Redefined
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
		internal int SelfReferenceCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal override string NameAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void SetQualifiedName(XmlQualifiedName value)
		{
		}

		internal override XmlSchemaObject Clone()
		{
			return null;
		}
	}
}
