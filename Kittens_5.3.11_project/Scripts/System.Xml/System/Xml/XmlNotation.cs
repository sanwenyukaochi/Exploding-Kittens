namespace System.Xml
{
	public class XmlNotation : XmlNode
	{
		private string publicId;

		private string systemId;

		private string name;

		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override bool IsReadOnly => false;

		public override string InnerXml
		{
			set
			{
			}
		}

		internal XmlNotation(string name, string publicId, string systemId, XmlDocument doc)
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
