using System.IO;
using System.Xml.Schema;

namespace System.Xml
{
	public sealed class XmlReaderSettings
	{
		private bool useAsync;

		private XmlNameTable nameTable;

		private XmlResolver xmlResolver;

		private int lineNumberOffset;

		private int linePositionOffset;

		private ConformanceLevel conformanceLevel;

		private bool checkCharacters;

		private long maxCharactersInDocument;

		private long maxCharactersFromEntities;

		private bool ignoreWhitespace;

		private bool ignorePIs;

		private bool ignoreComments;

		private DtdProcessing dtdProcessing;

		private ValidationType validationType;

		private XmlSchemaValidationFlags validationFlags;

		private XmlSchemaSet schemas;

		private ValidationEventHandler valEventHandler;

		private bool closeInput;

		private bool isReadOnly;

		private static bool? s_enableLegacyXmlSettings;

		public bool Async
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XmlNameTable NameTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsXmlResolverSet { get; set; }

		public XmlResolver XmlResolver
		{
			set
			{
			}
		}

		public int LineNumberOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LinePositionOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		public bool CheckCharacters
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long MaxCharactersInDocument
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long MaxCharactersFromEntities
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool IgnoreWhitespace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IgnoreProcessingInstructions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IgnoreComments
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public DtdProcessing DtdProcessing
		{
			get
			{
				return default(DtdProcessing);
			}
			set
			{
			}
		}

		public bool CloseInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ValidationType ValidationType
		{
			get
			{
				return default(ValidationType);
			}
			set
			{
			}
		}

		public XmlSchemaValidationFlags ValidationFlags
		{
			get
			{
				return default(XmlSchemaValidationFlags);
			}
			set
			{
			}
		}

		public XmlSchemaSet Schemas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool ReadOnly
		{
			set
			{
			}
		}

		internal XmlResolver GetXmlResolver()
		{
			return null;
		}

		internal XmlResolver GetXmlResolver_CheckConfig()
		{
			return null;
		}

		public XmlReaderSettings Clone()
		{
			return null;
		}

		internal ValidationEventHandler GetEventHandler()
		{
			return null;
		}

		internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext)
		{
			return null;
		}

		internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext)
		{
			return null;
		}

		private void CheckReadOnly(string propertyName)
		{
		}

		private void Initialize()
		{
		}

		private void Initialize(XmlResolver resolver)
		{
		}

		private static XmlResolver CreateDefaultResolver()
		{
			return null;
		}

		internal XmlReader AddValidation(XmlReader reader)
		{
			return null;
		}

		private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader)
		{
			return null;
		}

		internal static bool EnableLegacyXmlSettings()
		{
			return false;
		}
	}
}
