using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAll : XmlSchemaGroupBase
	{
		private XmlSchemaObjectCollection items;

		[XmlElement("element", typeof(XmlSchemaElement))]
		public override XmlSchemaObjectCollection Items => null;

		internal override bool IsEmpty => false;

		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
		}
	}
}
