using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaImport : XmlSchemaExternal
	{
		private string ns;

		private XmlSchemaAnnotation annotation;

		[XmlAttribute("namespace", DataType = "anyURI")]
		public string Namespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
		}
	}
}
