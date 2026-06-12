namespace System.Xml
{
	public class XmlCDataSection : XmlCharacterData
	{
		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlNode ParentNode => null;

		internal override bool IsText => false;

		protected internal XmlCDataSection(string data, XmlDocument doc)
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
