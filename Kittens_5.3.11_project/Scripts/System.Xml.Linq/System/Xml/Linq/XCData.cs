namespace System.Xml.Linq
{
	public class XCData : XText
	{
		public override XmlNodeType NodeType => default(XmlNodeType);

		public XCData(string value)
			: base((string)null)
		{
		}

		public XCData(XCData other)
			: base((string)null)
		{
		}

		public override void WriteTo(XmlWriter writer)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}
	}
}
