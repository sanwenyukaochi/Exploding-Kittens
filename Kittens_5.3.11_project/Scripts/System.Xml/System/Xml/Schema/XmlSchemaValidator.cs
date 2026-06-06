using System.Collections;
using System.Text;

namespace System.Xml.Schema
{
	public sealed class XmlSchemaValidator
	{
		private XmlSchemaSet schemaSet;

		private XmlSchemaValidationFlags validationFlags;

		private int startIDConstraint;

		private bool isRoot;

		private bool rootHasSchema;

		private bool attrValid;

		private bool checkEntity;

		private SchemaInfo compiledSchemaInfo;

		private IDtdInfo dtdSchemaInfo;

		private Hashtable validatedNamespaces;

		private HWStack validationStack;

		private ValidationState context;

		private ValidatorState currentState;

		private Hashtable attPresence;

		private SchemaAttDef wildID;

		private Hashtable IDs;

		private IdRefNode idRefListHead;

		private XmlQualifiedName contextQName;

		private string NsXs;

		private string NsXsi;

		private string NsXmlNs;

		private string NsXml;

		private XmlSchemaObject partialValidationType;

		private StringBuilder textValue;

		private ValidationEventHandler eventHandler;

		private object validationEventSender;

		private XmlNameTable nameTable;

		private IXmlLineInfo positionInfo;

		private IXmlLineInfo dummyPositionInfo;

		private XmlResolver xmlResolver;

		private Uri sourceUri;

		private string sourceUriString;

		private IXmlNamespaceResolver nsResolver;

		private XmlSchemaContentProcessing processContents;

		private string xsiTypeString;

		private string xsiNilString;

		private string xsiSchemaLocationString;

		private string xsiNoNamespaceSchemaLocationString;

		private static readonly XmlSchemaDatatype dtQName;

		private static readonly XmlSchemaDatatype dtCDATA;

		private static readonly XmlSchemaDatatype dtStringArray;

		private static XmlSchemaParticle[] EmptyParticleArray;

		private static XmlSchemaAttribute[] EmptyAttributeArray;

		private XmlCharType xmlCharType;

		internal static bool[,] ValidStates;

		private static string[] MethodNames;

		public XmlResolver XmlResolver
		{
			set
			{
			}
		}

		public IXmlLineInfo LineInfoProvider
		{
			set
			{
			}
		}

		public Uri SourceUri
		{
			set
			{
			}
		}

		public object ValidationEventSender
		{
			set
			{
			}
		}

		internal XmlSchemaSet SchemaSet => null;

		internal XmlSchemaValidationFlags ValidationFlags => default(XmlSchemaValidationFlags);

		internal XmlSchemaContentType CurrentContentType => default(XmlSchemaContentType);

		private bool StrictlyAssessed => false;

		private bool HasSchema => false;

		private bool HasIdentityConstraints => false;

		internal bool ProcessIdentityConstraints => false;

		internal bool ReportValidationWarnings => false;

		internal bool ProcessSchemaHints => false;

		public event ValidationEventHandler ValidationEventHandler
		{
			add
			{
			}
			remove
			{
			}
		}

		public XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags)
		{
		}

		private void Init()
		{
		}

		private void Reset()
		{
		}

		public void AddSchema(XmlSchema schema)
		{
		}

		public void Initialize()
		{
		}

		public void Initialize(XmlSchemaObject partialValidationType)
		{
		}

		public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
		}

		public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo)
		{
			return null;
		}

		private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo)
		{
			return null;
		}

		public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo)
		{
		}

		public void ValidateText(XmlValueGetter elementValue)
		{
		}

		private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter)
		{
		}

		public void ValidateWhitespace(XmlValueGetter elementValue)
		{
		}

		private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter)
		{
		}

		public object ValidateEndElement(XmlSchemaInfo schemaInfo)
		{
			return null;
		}

		public void SkipToEndElement(XmlSchemaInfo schemaInfo)
		{
		}

		public void EndValidation()
		{
		}

		internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData)
		{
		}

		internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo)
		{
		}

		internal string GetConcatenatedValue()
		{
			return null;
		}

		private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue)
		{
			return null;
		}

		private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
		{
		}

		private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext)
		{
			invalidElementInContext = default(bool);
			return null;
		}

		private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member)
		{
			return null;
		}

		private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType)
		{
			memberType = null;
			return null;
		}

		private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType)
		{
			memberType = null;
			return null;
		}

		private string GetTypeName(SchemaDeclBase decl)
		{
			return null;
		}

		private void SaveTextValue(object value)
		{
		}

		private void Push(XmlQualifiedName elementName)
		{
		}

		private void Pop()
		{
		}

		private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle)
		{
			return null;
		}

		private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound)
		{
			return null;
		}

		private void ThrowDeclNotFoundWarningOrError(bool declFound)
		{
		}

		private void CheckElementProperties()
		{
		}

		private void ValidateStartElementIdentityConstraints()
		{
		}

		private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName)
		{
			return null;
		}

		private void AddXmlNamespaceSchema()
		{
		}

		internal object CheckMixedValueConstraint(string elementValue)
		{
			return null;
		}

		private void LoadSchema(string uri, string url)
		{
		}

		internal void RecompileSchemaSet()
		{
		}

		private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue)
		{
		}

		private object CheckAttributeValue(object value, SchemaAttDef attdef)
		{
			return null;
		}

		private object CheckElementValue(string stringValue)
		{
			return null;
		}

		private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue)
		{
		}

		private object FindId(string name)
		{
			return null;
		}

		private void CheckForwardRefs()
		{
		}

		private void CheckStateTransition(ValidatorState toState, string methodName)
		{
		}

		private void ClearPSVI()
		{
		}

		private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl)
		{
		}

		private XmlSchemaElement GetSchemaElement()
		{
			return null;
		}

		internal string GetDefaultAttributePrefix(string attributeNS)
		{
			return null;
		}

		private void AddIdentityConstraints()
		{
		}

		private void ElementIdentityConstraints()
		{
		}

		private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype)
		{
		}

		private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype)
		{
		}

		internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
		}

		internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
		{
		}

		internal static string PrintExpectedElements(ArrayList expected, bool getParticles)
		{
			return null;
		}

		private static string PrintNames(ArrayList expected)
		{
			return null;
		}

		private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder)
		{
		}

		private static void EnumerateAny(StringBuilder builder, string namespaces)
		{
		}

		internal static string QNameString(string localName, string ns)
		{
			return null;
		}

		internal static string BuildElementName(XmlQualifiedName qname)
		{
			return null;
		}

		internal static string BuildElementName(string localName, string ns)
		{
			return null;
		}

		private void ProcessEntity(string name)
		{
		}

		private void SendValidationEvent(string code)
		{
		}

		private void SendValidationEvent(string code, string[] args)
		{
		}

		private void SendValidationEvent(string code, string arg)
		{
		}

		private void SendValidationEvent(string code, string arg1, string arg2)
		{
		}

		private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity)
		{
		}

		private void SendValidationEvent(string code, string[] args, Exception innerException)
		{
		}

		private void SendValidationEvent(XmlSchemaValidationException e)
		{
		}

		private void SendValidationEvent(XmlSchemaException e)
		{
		}

		private void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
		}

		private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity)
		{
		}

		internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity)
		{
		}
	}
}
