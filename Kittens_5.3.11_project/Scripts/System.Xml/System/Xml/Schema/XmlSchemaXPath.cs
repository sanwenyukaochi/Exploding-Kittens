using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaXPath : XmlSchemaAnnotated
	{
		private string xpath;

		[XmlAttribute("xpath")]
		[DefaultValue(null)]
		public string XPath
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
