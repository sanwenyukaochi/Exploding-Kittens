using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAnnotated : XmlSchemaObject
	{
		private string id;

		private XmlSchemaAnnotation annotation;

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

		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		public XmlSchemaAnnotation Annotation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] UnhandledAttributes
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

		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
		}

		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
		}
	}
}
