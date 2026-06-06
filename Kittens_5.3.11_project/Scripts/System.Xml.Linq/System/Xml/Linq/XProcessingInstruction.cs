namespace System.Xml.Linq
{
	public class XProcessingInstruction : XNode
	{
		internal string target;

		internal string data;

		public string Data => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public string Target => null;

		public XProcessingInstruction(string target, string data)
		{
		}

		public XProcessingInstruction(XProcessingInstruction other)
		{
		}

		public override void WriteTo(XmlWriter writer)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}

		private static void ValidateName(string name)
		{
		}
	}
}
