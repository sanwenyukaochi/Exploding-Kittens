namespace System.Xml
{
	public class XmlSignificantWhitespace : XmlCharacterData
	{
		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlNode ParentNode => null;

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

		internal override bool IsText => false;

		protected internal XmlSignificantWhitespace(string strData, XmlDocument doc)
			: base(null, null)
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
