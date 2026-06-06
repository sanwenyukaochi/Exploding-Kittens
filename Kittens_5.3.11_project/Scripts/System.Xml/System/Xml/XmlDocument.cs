using System.Collections;
using System.Xml.Schema;

namespace System.Xml
{
	public class XmlDocument : XmlNode
	{
		private XmlImplementation implementation;

		private DomNameTable domNameTable;

		private XmlLinkedNode lastChild;

		private XmlNamedNodeMap entities;

		private Hashtable htElementIdMap;

		private Hashtable htElementIDAttrDecl;

		private SchemaInfo schemaInfo;

		private XmlSchemaSet schemas;

		private bool reportValidity;

		private bool actualLoadingStatus;

		private XmlNodeChangedEventHandler onNodeInsertingDelegate;

		private XmlNodeChangedEventHandler onNodeInsertedDelegate;

		private XmlNodeChangedEventHandler onNodeRemovingDelegate;

		private XmlNodeChangedEventHandler onNodeRemovedDelegate;

		private XmlNodeChangedEventHandler onNodeChangingDelegate;

		private XmlNodeChangedEventHandler onNodeChangedDelegate;

		internal bool fEntRefNodesPresent;

		internal bool fCDataNodesPresent;

		private bool preserveWhitespace;

		private bool isLoading;

		internal string strDocumentName;

		internal string strDocumentFragmentName;

		internal string strCommentName;

		internal string strTextName;

		internal string strCDataSectionName;

		internal string strEntityName;

		internal string strID;

		internal string strXmlns;

		internal string strXml;

		internal string strSpace;

		internal string strLang;

		internal string strEmpty;

		internal string strNonSignificantWhitespaceName;

		internal string strSignificantWhitespaceName;

		internal string strReservedXmlns;

		internal string strReservedXml;

		internal string baseURI;

		private XmlResolver resolver;

		internal bool bSetResolver;

		internal object objLock;

		internal static EmptyEnumerator EmptyEnumerator;

		internal static IXmlSchemaInfo NotKnownSchemaInfo;

		internal static IXmlSchemaInfo ValidSchemaInfo;

		internal static IXmlSchemaInfo InvalidSchemaInfo;

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

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlNode ParentNode => null;

		public virtual XmlDocumentType DocumentType => null;

		internal virtual XmlDeclaration Declaration => null;

		public XmlImplementation Implementation => null;

		public override string Name => null;

		public override string LocalName => null;

		public XmlElement DocumentElement => null;

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

		public override XmlDocument OwnerDocument => null;

		public XmlSchemaSet Schemas
		{
			set
			{
			}
		}

		internal bool CanReportValidity => false;

		internal bool HasSetResolver => false;

		public virtual XmlResolver XmlResolver
		{
			set
			{
			}
		}

		public XmlNameTable NameTable => null;

		public override bool IsReadOnly => false;

		internal XmlNamedNodeMap Entities
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool ActualLoadingStatus => false;

		public override string InnerText
		{
			set
			{
			}
		}

		public override string InnerXml
		{
			set
			{
			}
		}

		internal string Version => null;

		internal string Encoding => null;

		internal string Standalone => null;

		public override IXmlSchemaInfo SchemaInfo => null;

		public override string BaseURI => null;

		public XmlDocument()
		{
		}

		public XmlDocument(XmlNameTable nt)
		{
		}

		protected internal XmlDocument(XmlImplementation imp)
		{
		}

		internal static void CheckName(string name)
		{
		}

		internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		internal bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			return false;
		}

		private XmlName GetIDInfoByElement_(XmlName eleName)
		{
			return null;
		}

		internal XmlName GetIDInfoByElement(XmlName eleName)
		{
			return null;
		}

		private WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			return null;
		}

		internal void AddElementWithId(string id, XmlElement elem)
		{
		}

		internal void RemoveElementWithId(string id, XmlElement elem)
		{
		}

		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		internal XmlResolver GetResolver()
		{
			return null;
		}

		internal override bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			return false;
		}

		private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			return false;
		}

		internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		public XmlAttribute CreateAttribute(string name)
		{
			return null;
		}

		internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
		}

		public virtual XmlCDataSection CreateCDataSection(string data)
		{
			return null;
		}

		public virtual XmlComment CreateComment(string data)
		{
			return null;
		}

		public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		public virtual XmlDocumentFragment CreateDocumentFragment()
		{
			return null;
		}

		public XmlElement CreateElement(string name)
		{
			return null;
		}

		internal void AddDefaultAttributes(XmlElement elem)
		{
		}

		private SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			return null;
		}

		private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			return null;
		}

		public virtual XmlEntityReference CreateEntityReference(string name)
		{
			return null;
		}

		public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		public virtual XmlText CreateTextNode(string text)
		{
			return null;
		}

		public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			return null;
		}

		public virtual XmlWhitespace CreateWhitespace(string text)
		{
			return null;
		}

		public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		public XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		private XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			return null;
		}

		private void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
		}

		private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
		}

		public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		public virtual XmlNode ReadNode(XmlReader reader)
		{
			return null;
		}

		private XmlTextReader SetupReader(XmlTextReader tr)
		{
			return null;
		}

		public virtual void Load(XmlReader reader)
		{
		}

		public virtual void LoadXml(string xml)
		{
		}

		public virtual void Save(XmlWriter w)
		{
		}

		public override void WriteTo(XmlWriter w)
		{
		}

		public override void WriteContentTo(XmlWriter xw)
		{
		}

		internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			return null;
		}

		internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			return null;
		}

		internal override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
		}

		internal override void AfterEvent(XmlNodeChangedEventArgs args)
		{
		}

		internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			return null;
		}

		internal XmlEntity GetEntityNode(string name)
		{
			return null;
		}

		internal void SetBaseURI(string inBaseURI)
		{
		}

		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}
	}
}
