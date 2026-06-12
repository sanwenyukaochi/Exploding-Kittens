using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaDocumentation : XmlSchemaObject
	{
		private string source;

		private string language;

		private XmlNode[] markup;

		private static XmlSchemaSimpleType languageType;

		[XmlAttribute("source", DataType = "anyURI")]
		public string Source
		{
			set
			{
			}
		}

		[XmlAttribute("xml:lang")]
		public string Language
		{
			set
			{
			}
		}

		[XmlAnyElement]
		[XmlText]
		public XmlNode[] Markup
		{
			set
			{
			}
		}
	}
}
