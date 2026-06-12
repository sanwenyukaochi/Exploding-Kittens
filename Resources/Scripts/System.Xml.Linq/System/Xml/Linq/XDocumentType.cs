namespace System.Xml.Linq
{
	public class XDocumentType : XNode
	{
		private string _name;

		private string _publicId;

		private string _systemId;

		private string _internalSubset;

		public string InternalSubset => null;

		public string Name => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public string PublicId => null;

		public string SystemId => null;

		public XDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
		}

		public XDocumentType(XDocumentType other)
		{
		}

		public override void WriteTo(XmlWriter writer)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}
	}
}
