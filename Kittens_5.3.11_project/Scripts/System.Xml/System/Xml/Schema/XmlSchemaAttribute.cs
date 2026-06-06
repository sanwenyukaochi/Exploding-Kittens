using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAttribute : XmlSchemaAnnotated
	{
		private string defaultValue;

		private string fixedValue;

		private string name;

		private XmlSchemaForm form;

		private XmlSchemaUse use;

		private XmlQualifiedName refName;

		private XmlQualifiedName typeName;

		private XmlQualifiedName qualifiedName;

		private XmlSchemaSimpleType type;

		private XmlSchemaSimpleType attributeType;

		private SchemaAttDef attDef;

		[DefaultValue(null)]
		[XmlAttribute("default")]
		public string DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("fixed")]
		[DefaultValue(null)]
		public string FixedValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("form")]
		[DefaultValue(XmlSchemaForm.None)]
		public XmlSchemaForm Form
		{
			get
			{
				return default(XmlSchemaForm);
			}
			set
			{
			}
		}

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

		[XmlAttribute("ref")]
		public XmlQualifiedName RefName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("type")]
		public XmlQualifiedName SchemaTypeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("simpleType")]
		public XmlSchemaSimpleType SchemaType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(XmlSchemaUse.None)]
		[XmlAttribute("use")]
		public XmlSchemaUse Use
		{
			get
			{
				return default(XmlSchemaUse);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlQualifiedName QualifiedName => null;

		[XmlIgnore]
		public XmlSchemaSimpleType AttributeSchemaType => null;

		[XmlIgnore]
		internal XmlSchemaDatatype Datatype => null;

		internal SchemaAttDef AttDef
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

		internal void SetAttributeType(XmlSchemaSimpleType value)
		{
		}

		internal override XmlSchemaObject Clone()
		{
			return null;
		}
	}
}
