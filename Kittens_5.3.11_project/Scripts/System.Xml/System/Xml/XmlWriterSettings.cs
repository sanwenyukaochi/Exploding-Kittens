using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.Xml
{
	public sealed class XmlWriterSettings
	{
		private bool useAsync;

		private Encoding encoding;

		private bool omitXmlDecl;

		private NewLineHandling newLineHandling;

		private string newLineChars;

		private TriState indent;

		private string indentChars;

		private bool newLineOnAttributes;

		private bool closeOutput;

		private NamespaceHandling namespaceHandling;

		private ConformanceLevel conformanceLevel;

		private bool checkCharacters;

		private bool writeEndDocumentOnClose;

		private XmlOutputMethod outputMethod;

		private List<XmlQualifiedName> cdataSections;

		private bool doNotEscapeUriAttributes;

		private bool mergeCDataSections;

		private string mediaType;

		private string docTypeSystem;

		private string docTypePublic;

		private XmlStandalone standalone;

		private bool autoXmlDecl;

		private bool isReadOnly;

		public bool Async => false;

		public Encoding Encoding => null;

		public bool OmitXmlDeclaration
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public NewLineHandling NewLineHandling => default(NewLineHandling);

		public string NewLineChars => null;

		public bool Indent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string IndentChars => null;

		public bool NewLineOnAttributes => false;

		public bool CloseOutput => false;

		public ConformanceLevel ConformanceLevel
		{
			get
			{
				return default(ConformanceLevel);
			}
			set
			{
			}
		}

		public bool CheckCharacters => false;

		public NamespaceHandling NamespaceHandling
		{
			get
			{
				return default(NamespaceHandling);
			}
			set
			{
			}
		}

		public bool WriteEndDocumentOnClose => false;

		public XmlOutputMethod OutputMethod
		{
			get
			{
				return default(XmlOutputMethod);
			}
			internal set
			{
			}
		}

		internal List<XmlQualifiedName> CDataSectionElements => null;

		public bool DoNotEscapeUriAttributes => false;

		internal bool MergeCDataSections => false;

		internal string MediaType => null;

		internal string DocTypeSystem => null;

		internal string DocTypePublic => null;

		internal XmlStandalone Standalone => default(XmlStandalone);

		internal bool AutoXmlDeclaration => false;

		internal TriState IndentInternal => default(TriState);

		internal bool IsQuerySpecific => false;

		internal bool ReadOnly
		{
			set
			{
			}
		}

		public XmlWriterSettings Clone()
		{
			return null;
		}

		internal XmlWriter CreateWriter(Stream output)
		{
			return null;
		}

		internal XmlWriter CreateWriter(TextWriter output)
		{
			return null;
		}

		private void CheckReadOnly(string propertyName)
		{
		}

		private void Initialize()
		{
		}
	}
}
