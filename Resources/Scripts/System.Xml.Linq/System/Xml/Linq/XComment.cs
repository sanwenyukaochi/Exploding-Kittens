namespace System.Xml.Linq
{
	public class XComment : XNode
	{
		internal string value;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public string Value => null;

		public XComment(string value)
		{
		}

		public XComment(XComment other)
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
