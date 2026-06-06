using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace System.Xml
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
	{
		private XmlTextReaderImpl impl;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override string Name => null;

		public override string LocalName => null;

		public override string NamespaceURI => null;

		public override string Prefix => null;

		public override string Value => null;

		public override int Depth => 0;

		public override string BaseURI => null;

		public override bool IsEmptyElement => false;

		public override bool IsDefault => false;

		public override char QuoteChar => '\0';

		public override XmlSpace XmlSpace => default(XmlSpace);

		public override string XmlLang => null;

		public override int AttributeCount => 0;

		public override bool EOF => false;

		public override ReadState ReadState => default(ReadState);

		public override XmlNameTable NameTable => null;

		public override bool CanResolveEntity => false;

		public override bool CanReadValueChunk => false;

		public int LineNumber => 0;

		public int LinePosition => 0;

		public bool Namespaces => false;

		public bool Normalization
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public WhitespaceHandling WhitespaceHandling
		{
			set
			{
			}
		}

		public EntityHandling EntityHandling
		{
			set
			{
			}
		}

		public XmlResolver XmlResolver
		{
			set
			{
			}
		}

		internal XmlTextReaderImpl Impl => null;

		internal override XmlNamespaceManager NamespaceManager => null;

		internal bool XmlValidatingReaderCompatibilityMode
		{
			set
			{
			}
		}

		internal override IDtdInfo DtdInfo => null;

		public XmlTextReader(Stream input)
		{
		}

		public XmlTextReader(string url, Stream input, XmlNameTable nt)
		{
		}

		public XmlTextReader(TextReader input)
		{
		}

		public XmlTextReader(TextReader input, XmlNameTable nt)
		{
		}

		public override string GetAttribute(string name)
		{
			return null;
		}

		public override string GetAttribute(string localName, string namespaceURI)
		{
			return null;
		}

		public override string GetAttribute(int i)
		{
			return null;
		}

		public override bool MoveToAttribute(string name)
		{
			return false;
		}

		public override void MoveToAttribute(int i)
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

		public override bool ReadAttributeValue()
		{
			return false;
		}

		public override bool Read()
		{
			return false;
		}

		public override void Close()
		{
		}

		public override void Skip()
		{
		}

		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		public override void ResolveEntity()
		{
		}

		public override string ReadString()
		{
			return null;
		}

		public bool HasLineInfo()
		{
			return false;
		}

		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return null;
		}

		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return null;
		}
	}
}
