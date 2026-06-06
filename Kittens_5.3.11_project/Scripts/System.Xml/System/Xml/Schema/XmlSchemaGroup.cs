using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaGroup : XmlSchemaAnnotated
	{
		private string name;

		private XmlSchemaGroupBase particle;

		private XmlSchemaParticle canonicalParticle;

		private XmlQualifiedName qname;

		private XmlSchemaGroup redefined;

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

		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		public XmlSchemaGroupBase Particle
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
		internal XmlSchemaParticle CanonicalParticle
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
		internal XmlSchemaGroup Redefined
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

		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			return null;
		}
	}
}
