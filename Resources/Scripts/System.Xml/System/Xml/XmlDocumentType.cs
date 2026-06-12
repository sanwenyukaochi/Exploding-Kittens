using System.Xml.Schema;

namespace System.Xml
{
	public class XmlDocumentType : XmlLinkedNode
	{
		private string name;

		private string publicId;

		private string systemId;

		private string internalSubset;

		private bool namespaces;

		private XmlNamedNodeMap entities;

		private XmlNamedNodeMap notations;

		private SchemaInfo schemaInfo;

		public override string Name => null;

		public override string LocalName => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override bool IsReadOnly => false;

		public XmlNamedNodeMap Entities => null;

		public XmlNamedNodeMap Notations => null;

		public string PublicId => null;

		public string SystemId => null;

		public string InternalSubset => null;

		internal bool ParseWithNamespaces => false;

		internal SchemaInfo DtdSchemaInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc)
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
