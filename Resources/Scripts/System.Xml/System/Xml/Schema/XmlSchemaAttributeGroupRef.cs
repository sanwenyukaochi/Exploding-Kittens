using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
	{
		private XmlQualifiedName refName;

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
	}
}
