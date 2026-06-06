namespace System.Xml
{
	public class XmlDeclaration : XmlLinkedNode
	{
		private string version;

		private string encoding;

		private string standalone;

		public string Version
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Encoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Standalone
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc)
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

		private bool IsValidXmlVersion(string ver)
		{
			return false;
		}
	}
}
