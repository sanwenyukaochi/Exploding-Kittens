using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
	{
		private string name;

		private XmlSchemaXPath selector;

		private XmlSchemaObjectCollection fields;

		private XmlQualifiedName qualifiedName;

		private CompiledIdentityConstraint compiledConstraint;

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

		[XmlElement("selector", typeof(XmlSchemaXPath))]
		public XmlSchemaXPath Selector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("field", typeof(XmlSchemaXPath))]
		public XmlSchemaObjectCollection Fields => null;

		[XmlIgnore]
		public XmlQualifiedName QualifiedName => null;

		[XmlIgnore]
		internal CompiledIdentityConstraint CompiledConstraint
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
	}
}
