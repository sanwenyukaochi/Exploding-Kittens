using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAppInfo : XmlSchemaObject
	{
		private string source;

		private XmlNode[] markup;

		[XmlAttribute("source", DataType = "anyURI")]
		public string Source
		{
			set
			{
			}
		}

		[XmlText]
		[XmlAnyElement]
		public XmlNode[] Markup
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
