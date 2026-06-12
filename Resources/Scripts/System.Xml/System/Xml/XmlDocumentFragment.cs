namespace System.Xml
{
	public class XmlDocumentFragment : XmlNode
	{
		private XmlLinkedNode lastChild;

		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlNode ParentNode => null;

		public override XmlDocument OwnerDocument => null;

		public override string InnerXml
		{
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

		protected internal XmlDocumentFragment(XmlDocument ownerDocument)
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

		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		public override void WriteTo(XmlWriter w)
		{
		}

		public override void WriteContentTo(XmlWriter w)
		{
		}
	}
}
