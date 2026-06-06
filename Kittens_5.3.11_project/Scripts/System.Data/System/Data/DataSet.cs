using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data
{
	[Serializable]
	[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[XmlRoot("DataSet")]
	[DefaultProperty("DataSetName")]
	[XmlSchemaProvider("GetDataSetSchema")]
	public class DataSet : MarshalByValueComponent, IListSource, IXmlSerializable, ISupportInitializeNotification, ISupportInitialize, ISerializable
	{
		private DataViewManager _defaultViewManager;

		private readonly DataTableCollection _tableCollection;

		private readonly DataRelationCollection _relationCollection;

		internal PropertyCollection _extendedProperties;

		private string _dataSetName;

		private string _datasetPrefix;

		internal string _namespaceURI;

		private bool _enforceConstraints;

		private bool _caseSensitive;

		private CultureInfo _culture;

		private bool _cultureUserSet;

		internal bool _fInReadXml;

		internal bool _fInLoadDiffgram;

		internal bool _fTopLevelTable;

		internal bool _fInitInProgress;

		internal bool _fEnableCascading;

		internal bool _fIsSchemaLoading;

		internal string _mainTableName;

		private SerializationFormat _remotingFormat;

		private object _defaultViewManagerLock;

		private static int s_objectTypeCount;

		private readonly int _objectID;

		private static XmlSchemaComplexType s_schemaTypeForWSDL;

		internal bool _useDataSetSchemaOnly;

		internal bool _udtIsWrapped;

		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;

		[CompilerGenerated]
		private MergeFailedEventHandler MergeFailed;

		[CompilerGenerated]
		private DataRowCreatedEventHandler DataRowCreated;

		[CompilerGenerated]
		private DataSetClearEventhandler ClearFunctionCalled;

		[DefaultValue(SerializationFormat.Xml)]
		public SerializationFormat RemotingFormat
		{
			get
			{
				return default(SerializationFormat);
			}
			set
			{
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual SchemaSerializationMode SchemaSerializationMode => default(SchemaSerializationMode);

		[DefaultValue(false)]
		public bool CaseSensitive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool IListSource.ContainsListCollection => false;

		[Browsable(false)]
		public DataViewManager DefaultViewManager => null;

		[DefaultValue(true)]
		public bool EnforceConstraints
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		public string DataSetName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		public string Namespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		public string Prefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Browsable(false)]
		public PropertyCollection ExtendedProperties => null;

		[Browsable(false)]
		public bool IsInitialized => false;

		public CultureInfo Locale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ISite Site
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataRelationCollection Relations => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataTableCollection Tables => null;

		internal string MainTableName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int ObjectID => 0;

		public event EventHandler Initialized
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public DataSet()
		{
		}

		public DataSet(string dataSetName)
		{
		}

		protected DataSet(SerializationInfo info, StreamingContext context)
		{
		}

		protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema)
		{
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		protected virtual void InitializeDerivedDataSet()
		{
		}

		private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
		{
		}

		internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
		{
		}

		private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode)
		{
		}

		private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat)
		{
		}

		private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context)
		{
		}

		private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context)
		{
		}

		private void SerializeRelations(SerializationInfo info, StreamingContext context)
		{
		}

		private void DeserializeRelations(SerializationInfo info, StreamingContext context)
		{
		}

		internal void FailedEnableConstraints()
		{
		}

		internal void RestoreEnforceConstraints(bool value)
		{
		}

		internal void EnableConstraints()
		{
		}

		internal void SetLocaleValue(CultureInfo value, bool userSet)
		{
		}

		internal bool ShouldSerializeLocale()
		{
			return false;
		}

		public void BeginInit()
		{
		}

		public void EndInit()
		{
		}

		public void Clear()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual DataSet Clone()
		{
			return null;
		}

		internal int EstimatedXmlStringSize()
		{
			return 0;
		}

		IList IListSource.GetList()
		{
			return null;
		}

		internal string GetRemotingDiffGram(DataTable table)
		{
			return null;
		}

		internal string GetXmlSchemaForRemoting(DataTable table)
		{
			return null;
		}

		public void ReadXmlSchema(XmlReader reader)
		{
		}

		internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
		{
		}

		internal bool MoveToElement(XmlReader reader, int depth)
		{
			return false;
		}

		private static void MoveToElement(XmlReader reader)
		{
		}

		internal void ReadEndElement(XmlReader reader)
		{
		}

		internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
		{
		}

		internal void ReadXDRSchema(XmlReader reader)
		{
		}

		private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter)
		{
		}

		public XmlReadMode ReadXml(XmlReader reader)
		{
			return default(XmlReadMode);
		}

		internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving)
		{
			return default(XmlReadMode);
		}

		internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode)
		{
		}

		private bool IsEmpty()
		{
			return false;
		}

		private void ReadXmlDiffgram(XmlReader reader)
		{
		}

		public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode)
		{
			return default(XmlReadMode);
		}

		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
		{
			return default(XmlReadMode);
		}

		public void WriteXml(XmlWriter writer, XmlWriteMode mode)
		{
		}

		public void Merge(DataSet dataSet)
		{
		}

		public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
		}

		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		internal void OnMergeFailed(MergeFailedEventArgs mfevent)
		{
		}

		internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction)
		{
		}

		internal void OnDataRowCreated(DataRow row)
		{
		}

		internal void OnClearFunctionCalled(DataTable table)
		{
		}

		private void OnInitialized()
		{
		}

		protected internal virtual void OnRemoveTable(DataTable table)
		{
		}

		internal void OnRemovedTable(DataTable table)
		{
		}

		protected virtual void OnRemoveRelation(DataRelation relation)
		{
		}

		internal void OnRemoveRelationHack(DataRelation relation)
		{
		}

		protected internal void RaisePropertyChanging(string name)
		{
		}

		internal DataTable[] TopLevelTables()
		{
			return null;
		}

		internal DataTable[] TopLevelTables(bool forSchema)
		{
			return null;
		}

		public virtual void Reset()
		{
		}

		internal bool ValidateCaseConstraint()
		{
			return false;
		}

		internal bool ValidateLocaleConstraint()
		{
			return false;
		}

		internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart)
		{
			return null;
		}

		protected virtual void ReadXmlSerializable(XmlReader reader)
		{
		}

		public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet)
		{
			return null;
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}
	}
}
