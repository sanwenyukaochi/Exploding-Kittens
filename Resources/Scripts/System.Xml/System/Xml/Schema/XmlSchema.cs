using System.Collections;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
	public class XmlSchema : XmlSchemaObject
	{
		private XmlSchemaForm attributeFormDefault;

		private XmlSchemaForm elementFormDefault;

		private XmlSchemaDerivationMethod blockDefault;

		private XmlSchemaDerivationMethod finalDefault;

		private string targetNs;

		private string version;

		private XmlSchemaObjectCollection includes;

		private XmlSchemaObjectCollection items;

		private string id;

		private XmlAttribute[] moreAttributes;

		private bool isCompiled;

		private bool isCompiledBySet;

		private bool isPreprocessed;

		private bool isRedefined;

		private int errorCount;

		private XmlSchemaObjectTable attributes;

		private XmlSchemaObjectTable attributeGroups;

		private XmlSchemaObjectTable elements;

		private XmlSchemaObjectTable types;

		private XmlSchemaObjectTable groups;

		private XmlSchemaObjectTable notations;

		private XmlSchemaObjectTable identityConstraints;

		private static int globalIdCounter;

		private ArrayList importedSchemas;

		private ArrayList importedNamespaces;

		private int schemaId;

		private Uri baseUri;

		private bool isChameleon;

		private Hashtable ids;

		private XmlDocument document;

		[DefaultValue(XmlSchemaForm.None)]
		[XmlAttribute("attributeFormDefault")]
		public XmlSchemaForm AttributeFormDefault
		{
			get
			{
				return default(XmlSchemaForm);
			}
			set
			{
			}
		}

		[XmlAttribute("blockDefault")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod BlockDefault
		{
			get
			{
				return default(XmlSchemaDerivationMethod);
			}
			set
			{
			}
		}

		[DefaultValue(XmlSchemaDerivationMethod.None)]
		[XmlAttribute("finalDefault")]
		public XmlSchemaDerivationMethod FinalDefault
		{
			get
			{
				return default(XmlSchemaDerivationMethod);
			}
			set
			{
			}
		}

		[DefaultValue(XmlSchemaForm.None)]
		[XmlAttribute("elementFormDefault")]
		public XmlSchemaForm ElementFormDefault
		{
			get
			{
				return default(XmlSchemaForm);
			}
			set
			{
			}
		}

		[XmlAttribute("targetNamespace", DataType = "anyURI")]
		public string TargetNamespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("version", DataType = "token")]
		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("include", typeof(XmlSchemaInclude))]
		[XmlElement("import", typeof(XmlSchemaImport))]
		[XmlElement("redefine", typeof(XmlSchemaRedefine))]
		public XmlSchemaObjectCollection Includes => null;

		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		[XmlElement("complexType", typeof(XmlSchemaComplexType))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("group", typeof(XmlSchemaGroup))]
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
		[XmlElement("notation", typeof(XmlSchemaNotation))]
		public XmlSchemaObjectCollection Items => null;

		[XmlIgnore]
		internal bool IsCompiledBySet
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal bool IsPreprocessed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal bool IsRedefined
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlSchemaObjectTable Attributes => null;

		[XmlIgnore]
		public XmlSchemaObjectTable AttributeGroups => null;

		[XmlIgnore]
		public XmlSchemaObjectTable SchemaTypes => null;

		[XmlIgnore]
		public XmlSchemaObjectTable Elements => null;

		[XmlAttribute("id", DataType = "ID")]
		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlSchemaObjectTable Groups => null;

		[XmlIgnore]
		public XmlSchemaObjectTable Notations => null;

		[XmlIgnore]
		internal XmlSchemaObjectTable IdentityConstraints => null;

		[XmlIgnore]
		internal Uri BaseUri
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal int SchemaId => 0;

		[XmlIgnore]
		internal bool IsChameleon
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal Hashtable Ids => null;

		[XmlIgnore]
		internal XmlDocument Document => null;

		[XmlIgnore]
		internal int ErrorCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal override string IdAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ArrayList ImportedSchemas => null;

		internal ArrayList ImportedNamespaces => null;

		public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler)
		{
			return null;
		}

		internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel)
		{
			return false;
		}

		internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		{
		}

		internal new XmlSchema Clone()
		{
			return null;
		}

		internal XmlSchema DeepClone()
		{
			return null;
		}

		internal void SetIsCompiled(bool isCompiled)
		{
		}

		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
		}

		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
		}

		internal void GetExternalSchemasList(IList extList, XmlSchema schema)
		{
		}
	}
}
