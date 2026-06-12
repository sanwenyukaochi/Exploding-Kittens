using System.Collections.Generic;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	public class XPathDocument
	{
		private XPathNode[] pageXmlNmsp;

		private int idxXmlNmsp;

		private XmlNameTable nameTable;

		private bool hasLineInfo;

		private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp;

		internal XmlNameTable NameTable => null;

		internal bool HasLineInfo => false;

		internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp)
		{
			pageXmlNmsp = null;
			return 0;
		}

		internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			pageNmsp = null;
			return 0;
		}
	}
}
