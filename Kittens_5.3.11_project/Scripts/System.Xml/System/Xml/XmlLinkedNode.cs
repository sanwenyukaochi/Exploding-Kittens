namespace System.Xml
{
	public abstract class XmlLinkedNode : XmlNode
	{
		internal XmlLinkedNode next;

		public override XmlNode PreviousSibling => null;

		public override XmlNode NextSibling => null;

		internal XmlLinkedNode(XmlDocument doc)
		{
		}
	}
}
