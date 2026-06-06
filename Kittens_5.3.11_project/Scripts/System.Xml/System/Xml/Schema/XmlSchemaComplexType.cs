using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaComplexType : XmlSchemaType
	{
		private XmlSchemaDerivationMethod block;

		private XmlSchemaContentModel contentModel;

		private XmlSchemaParticle particle;

		private XmlSchemaObjectCollection attributes;

		private XmlSchemaAnyAttribute anyAttribute;

		private XmlSchemaParticle contentTypeParticle;

		private XmlSchemaDerivationMethod blockResolved;

		private XmlSchemaObjectTable localElements;

		private XmlSchemaObjectTable attributeUses;

		private XmlSchemaAnyAttribute attributeWildcard;

		private static XmlSchemaComplexType anyTypeLax;

		private static XmlSchemaComplexType anyTypeSkip;

		private static XmlSchemaComplexType untypedAnyType;

		private byte pvFlags;

		[XmlIgnore]
		internal static XmlSchemaComplexType AnyType => null;

		[XmlIgnore]
		internal static XmlSchemaComplexType UntypedAnyType => null;

		internal static ContentValidator AnyTypeContentValidator => null;

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

		[XmlAttribute("block")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
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

		[XmlAttribute("mixed")]
		[DefaultValue(false)]
		public override bool IsMixed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
		[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
		public XmlSchemaContentModel ContentModel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		public XmlSchemaParticle Particle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
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
		public XmlSchemaContentType ContentType => default(XmlSchemaContentType);

		[XmlIgnore]
		public XmlSchemaParticle ContentTypeParticle => null;

		[XmlIgnore]
		public XmlSchemaDerivationMethod BlockResolved => default(XmlSchemaDerivationMethod);

		[XmlIgnore]
		public XmlSchemaObjectTable AttributeUses => null;

		[XmlIgnore]
		public XmlSchemaAnyAttribute AttributeWildcard => null;

		[XmlIgnore]
		internal XmlSchemaObjectTable LocalElements => null;

		internal bool HasWildCard
		{
			set
			{
			}
		}

		static XmlSchemaComplexType()
		{
		}

		private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			return null;
		}

		internal void SetContentTypeParticle(XmlSchemaParticle value)
		{
		}

		internal void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
		}

		internal void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
		}

		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
		}

		internal bool ContainsIdAttribute(bool findAll)
		{
			return false;
		}

		internal override XmlSchemaObject Clone()
		{
			return null;
		}

		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			return null;
		}

		private void ClearCompiledState()
		{
		}

		internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes)
		{
			return null;
		}

		private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema)
		{
			return null;
		}

		internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			return null;
		}

		private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element)
		{
			return default(XmlSchemaForm);
		}

		internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			return false;
		}

		internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes)
		{
			return false;
		}
	}
}
