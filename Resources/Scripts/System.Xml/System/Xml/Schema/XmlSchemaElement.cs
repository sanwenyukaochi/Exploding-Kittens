using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaElement : XmlSchemaParticle
	{
		private bool isAbstract;

		private bool hasAbstractAttribute;

		private bool isNillable;

		private bool hasNillableAttribute;

		private bool isLocalTypeDerivationChecked;

		private XmlSchemaDerivationMethod block;

		private XmlSchemaDerivationMethod final;

		private XmlSchemaForm form;

		private string defaultValue;

		private string fixedValue;

		private string name;

		private XmlQualifiedName refName;

		private XmlQualifiedName substitutionGroup;

		private XmlQualifiedName typeName;

		private XmlSchemaType type;

		private XmlQualifiedName qualifiedName;

		private XmlSchemaType elementType;

		private XmlSchemaDerivationMethod blockResolved;

		private XmlSchemaDerivationMethod finalResolved;

		private XmlSchemaObjectCollection constraints;

		private SchemaElementDecl elementDecl;

		[XmlAttribute("abstract")]
		[DefaultValue(false)]
		public bool IsAbstract
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DefaultValue(XmlSchemaDerivationMethod.None)]
		[XmlAttribute("block")]
		public XmlSchemaDerivationMethod Block
		{
			get
			{
				return default(XmlSchemaDerivationMethod);
			}
			set
			{
			}
		}

		[XmlAttribute("default")]
		[DefaultValue(null)]
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

		[DefaultValue(XmlSchemaDerivationMethod.None)]
		[XmlAttribute("final")]
		public XmlSchemaDerivationMethod Final
		{
			get
			{
				return default(XmlSchemaDerivationMethod);
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		[XmlAttribute("fixed")]
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

		[DefaultValue(XmlSchemaForm.None)]
		[XmlAttribute("form")]
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

		[DefaultValue(null)]
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

		[XmlAttribute("nillable")]
		[DefaultValue(false)]
		public bool IsNillable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal bool HasNillableAttribute => false;

		[XmlIgnore]
		internal bool HasAbstractAttribute => false;

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

		[XmlAttribute("substitutionGroup")]
		public XmlQualifiedName SubstitutionGroup
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

		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		[XmlElement("complexType", typeof(XmlSchemaComplexType))]
		public XmlSchemaType SchemaType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("keyref", typeof(XmlSchemaKeyref))]
		[XmlElement("unique", typeof(XmlSchemaUnique))]
		[XmlElement("key", typeof(XmlSchemaKey))]
		public XmlSchemaObjectCollection Constraints => null;

		[XmlIgnore]
		public XmlQualifiedName QualifiedName => null;

		[XmlIgnore]
		public XmlSchemaType ElementSchemaType => null;

		[XmlIgnore]
		public XmlSchemaDerivationMethod BlockResolved => default(XmlSchemaDerivationMethod);

		[XmlIgnore]
		public XmlSchemaDerivationMethod FinalResolved => default(XmlSchemaDerivationMethod);

		internal bool HasConstraints => false;

		internal bool IsLocalTypeDerivationChecked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal SchemaElementDecl ElementDecl
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

		[XmlIgnore]
		internal override string NameString => null;

		internal void SetQualifiedName(XmlQualifiedName value)
		{
		}

		internal void SetElementType(XmlSchemaType value)
		{
		}

		internal void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
		}

		internal void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
		}

		internal override XmlSchemaObject Clone()
		{
			return null;
		}

		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			return null;
		}
	}
}
