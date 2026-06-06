using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		private XmlSchemaObjectCollection items;

		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		public override XmlSchemaObjectCollection Items => null;

		internal override bool IsEmpty => false;

		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
		}
	}
}
