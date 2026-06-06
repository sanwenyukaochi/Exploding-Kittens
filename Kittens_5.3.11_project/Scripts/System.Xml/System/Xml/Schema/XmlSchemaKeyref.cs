using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
	{
		private XmlQualifiedName refer;

		[XmlAttribute("refer")]
		public XmlQualifiedName Refer
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
