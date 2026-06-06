using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml
{
	public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
	{
		private XmlNodeReaderNavigator readerNav;

		private XmlNodeType nodeType;

		private int curDepth;

		private ReadState readState;

		private bool fEOF;

		private bool bResolveEntity;

		private bool bStartFromDocument;

		private bool bInReadBinary;

		private ReadContentAsBinaryHelper readBinaryHelper;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override string Name => null;

		public override string LocalName => null;

		public override string NamespaceURI => null;

		public override string Prefix => null;

		public override string Value => null;

		public override int Depth => 0;

		public override string BaseURI => null;

		public override bool CanResolveEntity => false;

		public override bool IsEmptyElement => false;

		public override bool IsDefault => false;

		public override XmlSpace XmlSpace => default(XmlSpace);

		public override string XmlLang => null;

		public override IXmlSchemaInfo SchemaInfo => null;

		public override int AttributeCount => 0;

		public override bool EOF => false;

		public override ReadState ReadState => default(ReadState);

		public override bool HasAttributes => false;

		public override XmlNameTable NameTable => null;

		internal override IDtdInfo DtdInfo => null;

		public XmlNodeReader(XmlNode node)
		{
		}

		internal bool IsInReadingStates()
		{
			return false;
		}

		public override string GetAttribute(string name)
		{
			return null;
		}

		public override string GetAttribute(string name, string namespaceURI)
		{
			return null;
		}

		public override string GetAttribute(int attributeIndex)
		{
			return null;
		}

		public override bool MoveToAttribute(string name)
		{
			return false;
		}

		public override void MoveToAttribute(int attributeIndex)
		{
		}

		public override bool MoveToFirstAttribute()
		{
			return false;
		}

		public override bool MoveToNextAttribute()
		{
			return false;
		}

		public override bool MoveToElement()
		{
			return false;
		}

		public override bool Read()
		{
			return false;
		}

		private bool Read(bool fSkipChildren)
		{
			return false;
		}

		private bool ReadNextNode(bool fSkipChildren)
		{
			return false;
		}

		private void SetEndOfFile()
		{
		}

		private bool ReadAtZeroLevel(bool fSkipChildren)
		{
			return false;
		}

		private bool ReadForward(bool fSkipChildren)
		{
			return false;
		}

		private void ReSetReadingMarks()
		{
		}

		public override void Close()
		{
		}

		public override void Skip()
		{
		}

		public override string ReadString()
		{
			return null;
		}

		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		public override void ResolveEntity()
		{
		}

		public override bool ReadAttributeValue()
		{
			return false;
		}

		private void FinishReadBinary()
		{
		}

		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return null;
		}

		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return null;
		}
	}
}
