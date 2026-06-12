namespace System.Xml
{
	public class XmlEntityReference : XmlLinkedNode
	{
		private string name;

		private XmlLinkedNode lastChild;

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

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override bool IsReadOnly => false;

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

		public override string BaseURI => null;

		internal string ChildBaseURI => null;

		protected internal XmlEntityReference(string name, XmlDocument doc)
			: base(null)
		{
		}

		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		internal override void SetParent(XmlNode node)
		{
		}

		internal override void SetParentForLoad(XmlNode node)
		{
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

		private string ConstructBaseURI(string baseURI, string systemId)
		{
			return null;
		}
	}
}
