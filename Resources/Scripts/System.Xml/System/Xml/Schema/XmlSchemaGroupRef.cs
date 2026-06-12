using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaGroupRef : XmlSchemaParticle
	{
		private XmlQualifiedName refName;

		private XmlSchemaGroupBase particle;

		private XmlSchemaGroup refined;

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

		[XmlIgnore]
		public XmlSchemaGroupBase Particle => null;

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

		internal void SetParticle(XmlSchemaGroupBase value)
		{
		}
	}
}
