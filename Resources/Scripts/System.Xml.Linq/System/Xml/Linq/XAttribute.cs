namespace System.Xml.Linq
{
	public class XAttribute : XObject
	{
		internal XAttribute next;

		internal XName name;

		internal string value;

		public bool IsNamespaceDeclaration => false;

		public XName Name => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public string Value => null;

		public XAttribute(XName name, object value)
		{
		}

		public XAttribute(XAttribute other)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal string GetPrefixOfNamespace(XNamespace ns)
		{
			return null;
		}

		private static void ValidateAttribute(XName name, string value)
		{
		}
	}
}
