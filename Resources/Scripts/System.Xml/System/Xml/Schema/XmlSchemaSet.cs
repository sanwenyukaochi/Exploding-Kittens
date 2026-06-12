using System.Collections;

namespace System.Xml.Schema
{
	public class XmlSchemaSet
	{
		private XmlNameTable nameTable;

		private SchemaNames schemaNames;

		private SortedList schemas;

		private ValidationEventHandler internalEventHandler;

		private ValidationEventHandler eventHandler;

		private bool isCompiled;

		private Hashtable schemaLocations;

		private Hashtable chameleonSchemas;

		private Hashtable targetNamespaces;

		private bool compileAll;

		private SchemaInfo cachedCompiledInfo;

		private XmlReaderSettings readerSettings;

		private XmlSchema schemaForSchema;

		private XmlSchemaCompilationSettings compilationSettings;

		internal XmlSchemaObjectTable elements;

		internal XmlSchemaObjectTable attributes;

		internal XmlSchemaObjectTable schemaTypes;

		internal XmlSchemaObjectTable substitutionGroups;

		private XmlSchemaObjectTable typeExtensions;

		private object internalSyncObject;

		internal object InternalSyncObject => null;

		public bool IsCompiled => false;

		public XmlResolver XmlResolver
		{
			set
			{
			}
		}

		public XmlSchemaCompilationSettings CompilationSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public XmlSchemaObjectTable GlobalElements => null;

		public XmlSchemaObjectTable GlobalAttributes => null;

		public XmlSchemaObjectTable GlobalTypes => null;

		internal XmlSchemaObjectTable SubstitutionGroups => null;

		internal Hashtable SchemaLocations => null;

		internal XmlSchemaObjectTable TypeExtensions => null;

		internal SchemaInfo CompiledInfo => null;

		internal XmlReaderSettings ReaderSettings => null;

		internal SortedList SortedSchemas => null;

		public event ValidationEventHandler ValidationEventHandler
		{
			add
			{
			}
			remove
			{
			}
		}

		public XmlSchemaSet()
		{
		}

		public XmlSchemaSet(XmlNameTable nameTable)
		{
		}

		public void Add(XmlSchemaSet schemas)
		{
		}

		public XmlSchema Add(XmlSchema schema)
		{
			return null;
		}

		public bool RemoveRecursive(XmlSchema schemaToRemove)
		{
			return false;
		}

		public bool Contains(string targetNamespace)
		{
			return false;
		}

		public void Compile()
		{
		}

		public XmlSchema Reprocess(XmlSchema schema)
		{
			return null;
		}

		public void CopyTo(XmlSchema[] schemas, int index)
		{
		}

		public ICollection Schemas()
		{
			return null;
		}

		public ICollection Schemas(string targetNamespace)
		{
			return null;
		}

		private XmlSchema Add(string targetNamespace, XmlSchema schema)
		{
			return null;
		}

		internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces)
		{
		}

		internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable)
		{
			return null;
		}

		private void AddSchemaToSet(XmlSchema schema)
		{
		}

		private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve)
		{
		}

		private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable)
		{
		}

		internal XmlSchema Remove(XmlSchema schema, bool forceCompile)
		{
			return null;
		}

		private void ClearTables()
		{
		}

		internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace)
		{
			return false;
		}

		internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader)
		{
			return null;
		}

		internal void CopyFromCompiledSet(XmlSchemaSet otherSet)
		{
		}

		internal XmlResolver GetResolver()
		{
			return null;
		}

		internal ValidationEventHandler GetEventHandler()
		{
			return null;
		}

		internal SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			return null;
		}

		internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema)
		{
			schema = null;
			return false;
		}

		internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema)
		{
			schema = null;
			return false;
		}

		internal string GetTargetNamespace(XmlSchema schema)
		{
			return null;
		}

		private void RemoveSchemaFromCaches(XmlSchema schema)
		{
		}

		private void RemoveSchemaFromGlobalTables(XmlSchema schema)
		{
		}

		private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
		{
			return false;
		}

		private void VerifyTables()
		{
		}

		private void InternalValidationCallback(object sender, ValidationEventArgs e)
		{
		}

		private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
		}
	}
}
