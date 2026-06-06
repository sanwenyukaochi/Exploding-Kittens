namespace System.Xml.Linq
{
	public class XDocument : XContainer
	{
		private XDeclaration _declaration;

		public XDeclaration Declaration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override XmlNodeType NodeType => default(XmlNodeType);

		public XElement Root => null;

		public XDocument()
		{
		}

		public XDocument(XDocument other)
		{
		}

		public override void WriteTo(XmlWriter writer)
		{
		}

		internal override void AddAttribute(XAttribute a)
		{
		}

		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}

		private T GetFirstNode<T>() where T : XNode
		{
			return null;
		}

		internal static bool IsWhitespace(string s)
		{
			return false;
		}

		internal override void ValidateNode(XNode node, XNode previous)
		{
		}

		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
		}

		internal override void ValidateString(string s)
		{
		}
	}
}
