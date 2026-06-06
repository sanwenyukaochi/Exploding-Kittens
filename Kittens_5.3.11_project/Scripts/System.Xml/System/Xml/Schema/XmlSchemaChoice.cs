using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		private XmlSchemaObjectCollection items;

		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		public override XmlSchemaObjectCollection Items => null;

		internal override bool IsEmpty => false;

		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
		}
	}
}
