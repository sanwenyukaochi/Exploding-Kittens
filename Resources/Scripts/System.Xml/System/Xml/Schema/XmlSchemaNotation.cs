using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaNotation : XmlSchemaAnnotated
	{
		private string name;

		private string publicId;

		private string systemId;

		private XmlQualifiedName qname;

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

		[XmlAttribute("public")]
		public string Public
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("system")]
		public string System
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
		internal XmlQualifiedName QualifiedName
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
	}
}
