namespace System.Xml
{
	public class XmlComment : XmlCharacterData
	{
		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		protected internal XmlComment(string comment, XmlDocument doc)
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
