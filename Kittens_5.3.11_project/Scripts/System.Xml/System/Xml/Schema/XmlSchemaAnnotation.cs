using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAnnotation : XmlSchemaObject
	{
		private string id;

		private XmlSchemaObjectCollection items;

		private XmlAttribute[] moreAttributes;

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

		[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
		[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
		public XmlSchemaObjectCollection Items => null;

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

		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
		}
	}
}
