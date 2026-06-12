using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public abstract class XmlSchemaExternal : XmlSchemaObject
	{
		private string location;

		private Uri baseUri;

		private XmlSchema schema;

		private string id;

		private XmlAttribute[] moreAttributes;

		private Compositor compositor;

		[XmlAttribute("schemaLocation", DataType = "anyURI")]
		public string SchemaLocation
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
		public XmlSchema Schema
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("id", DataType = "ID")]
		public string Id
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
		internal Uri BaseUri
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
		internal override string IdAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Compositor Compositor
		{
			get
			{
				return default(Compositor);
			}
			set
			{
			}
		}

		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
		}
	}
}
