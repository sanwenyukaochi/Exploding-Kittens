namespace System.Xml
{
	public class XmlProcessingInstruction : XmlLinkedNode
	{
		private string target;

		private string data;

		public override string Name => null;

		public override string LocalName => null;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Data
		{
			set
			{
			}
		}

		public override string InnerText
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

		protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc)
			: base(null)
		{
		}

		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		public override void WriteTo(XmlWriter w)
		{
		}

		public override void WriteContentTo(XmlWriter w)
		{
		}
	}
}
