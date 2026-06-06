using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace System.Xml
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlTextWriter : XmlWriter
	{
		private enum NamespaceState
		{
			Uninitialized = 0,
			NotDeclaredButInScope = 1,
			DeclaredButNotWrittenOut = 2,
			DeclaredAndWrittenOut = 3
		}

		private struct TagInfo
		{
			internal string name;

			internal string prefix;

			internal string defaultNs;

			internal NamespaceState defaultNsState;

			internal XmlSpace xmlSpace;

			internal string xmlLang;

			internal int prevNsTop;

			internal int prefixCount;

			internal bool mixed;

			internal void Init(int nsTop)
			{
			}
		}

		private struct Namespace
		{
			internal string prefix;

			internal string ns;

			internal bool declared;

			internal int prevNsIndex;

			internal void Set(string prefix, string ns, bool declared)
			{
			}
		}

		private enum SpecialAttr
		{
			None = 0,
			XmlSpace = 1,
			XmlLang = 2,
			XmlNs = 3
		}

		private enum State
		{
			Start = 0,
			Prolog = 1,
			PostDTD = 2,
			Element = 3,
			Attribute = 4,
			Content = 5,
			AttrOnly = 6,
			Epilog = 7,
			Error = 8,
			Closed = 9
		}

		private enum Token
		{
			PI = 0,
			Doctype = 1,
			Comment = 2,
			CData = 3,
			StartElement = 4,
			EndElement = 5,
			LongEndElement = 6,
			StartAttribute = 7,
			EndAttribute = 8,
			Content = 9,
			Base64 = 10,
			RawData = 11,
			Whitespace = 12,
			Empty = 13
		}

		private TextWriter textWriter;

		private XmlTextEncoder xmlEncoder;

		private Encoding encoding;

		private Formatting formatting;

		private bool indented;

		private int indentation;

		private char indentChar;

		private TagInfo[] stack;

		private int top;

		private State[] stateTable;

		private State currentState;

		private Token lastToken;

		private XmlTextWriterBase64Encoder base64Encoder;

		private char quoteChar;

		private char curQuoteChar;

		private bool namespaces;

		private SpecialAttr specialAttr;

		private string prefixForXmlNs;

		private bool flush;

		private Namespace[] nsStack;

		private int nsTop;

		private Dictionary<string, int> nsHashtable;

		private bool useNsHashtable;

		private XmlCharType xmlCharType;

		private static string[] stateName;

		private static string[] tokenName;

		private static readonly State[] stateTableDefault;

		private static readonly State[] stateTableDocument;

		public Stream BaseStream => null;

		public bool Namespaces
		{
			set
			{
			}
		}

		public Formatting Formatting
		{
			set
			{
			}
		}

		public char QuoteChar
		{
			set
			{
			}
		}

		public override WriteState WriteState => default(WriteState);

		internal XmlTextWriter()
		{
		}

		public XmlTextWriter(Stream w, Encoding encoding)
		{
		}

		public XmlTextWriter(string filename, Encoding encoding)
		{
		}

		public XmlTextWriter(TextWriter w)
		{
		}

		public override void WriteStartDocument()
		{
		}

		public override void WriteStartDocument(bool standalone)
		{
		}

		public override void WriteEndDocument()
		{
		}

		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		public override void WriteEndElement()
		{
		}

		public override void WriteFullEndElement()
		{
		}

		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		public override void WriteEndAttribute()
		{
		}

		public override void WriteCData(string text)
		{
		}

		public override void WriteComment(string text)
		{
		}

		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		public override void WriteEntityRef(string name)
		{
		}

		public override void WriteCharEntity(char ch)
		{
		}

		public override void WriteWhitespace(string ws)
		{
		}

		public override void WriteString(string text)
		{
		}

		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		public override void WriteRaw(string data)
		{
		}

		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		public override void Close()
		{
		}

		public override void Flush()
		{
		}

		public override string LookupPrefix(string ns)
		{
			return null;
		}

		private void StartDocument(int standalone)
		{
		}

		private void AutoComplete(Token token)
		{
		}

		private void AutoCompleteAll()
		{
		}

		private void InternalWriteEndElement(bool longFormat)
		{
		}

		private void WriteEndStartTag(bool empty)
		{
		}

		private void WriteEndAttributeQuote()
		{
		}

		private void Indent(bool beforeEndElement)
		{
		}

		private void PushNamespace(string prefix, string ns, bool declared)
		{
		}

		private void AddNamespace(string prefix, string ns, bool declared)
		{
		}

		private void AddToNamespaceHashtable(int namespaceIndex)
		{
		}

		private void PopNamespaces(int indexFrom, int indexTo)
		{
		}

		private string GeneratePrefix()
		{
			return null;
		}

		private void InternalWriteProcessingInstruction(string name, string text)
		{
		}

		private int LookupNamespace(string prefix)
		{
			return 0;
		}

		private int LookupNamespaceInCurrentScope(string prefix)
		{
			return 0;
		}

		private string FindPrefix(string ns)
		{
			return null;
		}

		private void ValidateName(string name, bool isNCName)
		{
		}

		private void HandleSpecialAttribute()
		{
		}

		private void VerifyPrefixXml(string prefix, string ns)
		{
		}

		private void PushStack()
		{
		}

		private void FlushEncoders()
		{
		}
	}
}
