namespace System.Xml
{
	public class XmlEntity : XmlNode
	{
		private string publicId;

		private string systemId;

		private string notationName;

		private string name;

		private string unparsedReplacementStr;

		private string baseURI;

		private XmlLinkedNode lastChild;

		private bool childrenFoliating;

		public override bool IsReadOnly => false;

		public override string Name => null;

		public override string LocalName => null;

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

		internal override bool IsContainer => false;

		internal override XmlLinkedNode LastNode
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

		public string SystemId => null;

		public override string InnerXml
		{
			set
			{
			}
		}

		public override string BaseURI => null;

		internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc)
		{
		}

		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		internal override bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		public override void WriteTo(XmlWriter w)
		{
		}

		public override void WriteContentTo(XmlWriter w)
		{
		}

		internal void SetBaseURI(string inBaseURI)
		{
		}
	}
}
