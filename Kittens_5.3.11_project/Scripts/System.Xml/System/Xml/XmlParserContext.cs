using System.Text;

namespace System.Xml
{
	public class XmlParserContext
	{
		private XmlNameTable _nt;

		private XmlNamespaceManager _nsMgr;

		private string _docTypeName;

		private string _pubId;

		private string _sysId;

		private string _internalSubset;

		private string _xmlLang;

		private XmlSpace _xmlSpace;

		private string _baseURI;

		private Encoding _encoding;

		public XmlNameTable NameTable => null;

		public XmlNamespaceManager NamespaceManager => null;

		public string DocTypeName => null;

		public string PublicId => null;

		public string SystemId => null;

		public string BaseURI => null;

		public string InternalSubset => null;

		public string XmlLang => null;

		public XmlSpace XmlSpace => default(XmlSpace);

		public Encoding Encoding => null;

		internal bool HasDtdInfo => false;

		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace)
		{
		}

		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
		{
		}

		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
		{
		}
	}
}
