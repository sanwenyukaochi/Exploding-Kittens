using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Schema;

namespace System.Xml
{
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlReader : IDisposable
	{
		private static uint IsTextualNodeBitmap;

		private static uint CanReadContentAsBitmap;

		private static uint HasValueBitmap;

		public virtual XmlReaderSettings Settings => null;

		public abstract XmlNodeType NodeType { get; }

		public virtual string Name => null;

		public abstract string LocalName { get; }

		public abstract string NamespaceURI { get; }

		public abstract string Prefix { get; }

		public abstract string Value { get; }

		public abstract int Depth { get; }

		public abstract string BaseURI { get; }

		public abstract bool IsEmptyElement { get; }

		public virtual bool IsDefault => false;

		public virtual char QuoteChar => '\0';

		public virtual XmlSpace XmlSpace => default(XmlSpace);

		public virtual string XmlLang => null;

		public virtual IXmlSchemaInfo SchemaInfo => null;

		public virtual Type ValueType => null;

		public abstract int AttributeCount { get; }

		public abstract bool EOF { get; }

		public abstract ReadState ReadState { get; }

		public abstract XmlNameTable NameTable { get; }

		public virtual bool CanResolveEntity => false;

		public virtual bool CanReadValueChunk => false;

		public virtual bool HasAttributes => false;

		internal virtual XmlNamespaceManager NamespaceManager => null;

		internal bool IsDefaultInternal => false;

		internal virtual IDtdInfo DtdInfo => null;

		public abstract string GetAttribute(string name);

		public abstract string GetAttribute(string name, string namespaceURI);

		public abstract string GetAttribute(int i);

		public abstract bool MoveToAttribute(string name);

		public virtual void MoveToAttribute(int i)
		{
		}

		public abstract bool MoveToFirstAttribute();

		public abstract bool MoveToNextAttribute();

		public abstract bool MoveToElement();

		public abstract bool ReadAttributeValue();

		public abstract bool Read();

		public virtual void Close()
		{
		}

		public virtual void Skip()
		{
		}

		public abstract string LookupNamespace(string prefix);

		public abstract void ResolveEntity();

		public virtual int ReadValueChunk(char[] buffer, int index, int count)
		{
			return 0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadString()
		{
			return null;
		}

		public virtual XmlNodeType MoveToContent()
		{
			return default(XmlNodeType);
		}

		public virtual void ReadStartElement()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadElementString()
		{
			return null;
		}

		public virtual void ReadEndElement()
		{
		}

		public virtual bool IsStartElement(string localname, string ns)
		{
			return false;
		}

		public virtual string ReadInnerXml()
		{
			return null;
		}

		private void WriteNode(XmlWriter xtw, bool defattr)
		{
		}

		private void WriteAttributeValue(XmlWriter xtw)
		{
		}

		private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw)
		{
			return null;
		}

		private void SetNamespacesFlag(XmlTextWriter xtw)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		internal static bool IsTextualNode(XmlNodeType nodeType)
		{
			return false;
		}

		internal static bool HasValueInternal(XmlNodeType nodeType)
		{
			return false;
		}

		private bool SkipSubtree()
		{
			return false;
		}

		public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri)
		{
			return null;
		}

		public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri)
		{
			return null;
		}

		internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			return null;
		}

		internal static int CalcBufferSize(Stream input)
		{
			return 0;
		}
	}
}
