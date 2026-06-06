using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data
{
	[Serializable]
	[DesignTimeVisible(false)]
	[DefaultProperty("TableName")]
	[ToolboxItem(false)]
	[XmlSchemaProvider("GetDataTableSchema")]
	[DefaultEvent("RowChanging")]
	public class DataTable : MarshalByValueComponent, IListSource, ISupportInitializeNotification, ISupportInitialize, ISerializable, IXmlSerializable
	{
		internal struct RowDiffIdUsageSection
		{
			private DataTable _targetTable;

			internal void Prepare(DataTable table)
			{
			}
		}

		internal struct DSRowDiffIdUsageSection
		{
			private DataSet _targetDS;

			internal void Prepare(DataSet ds)
			{
			}
		}

		private DataSet _dataSet;

		private DataView _defaultView;

		internal long _nextRowID;

		internal readonly DataRowCollection _rowCollection;

		internal readonly DataColumnCollection _columnCollection;

		private readonly ConstraintCollection _constraintCollection;

		private int _elementColumnCount;

		internal DataRelationCollection _parentRelationsCollection;

		internal DataRelationCollection _childRelationsCollection;

		internal readonly RecordManager _recordManager;

		internal readonly List<Index> _indexes;

		private List<Index> _shadowIndexes;

		private int _shadowCount;

		internal PropertyCollection _extendedProperties;

		private string _tableName;

		internal string _tableNamespace;

		private string _tablePrefix;

		internal DataExpression _displayExpression;

		internal bool _fNestedInDataset;

		private CultureInfo _culture;

		private bool _cultureUserSet;

		private CompareInfo _compareInfo;

		private CompareOptions _compareFlags;

		private IFormatProvider _formatProvider;

		private StringComparer _hashCodeProvider;

		private bool _caseSensitive;

		private bool _caseSensitiveUserSet;

		internal string _encodedTableName;

		internal DataColumn _xmlText;

		internal DataColumn _colUnique;

		internal decimal _minOccurs;

		internal decimal _maxOccurs;

		internal bool _repeatableElement;

		private object _typeName;

		internal UniqueConstraint _primaryKey;

		internal IndexField[] _primaryIndex;

		private DataColumn[] _delayedSetPrimaryKey;

		private Index _loadIndex;

		private Index _loadIndexwithOriginalAdded;

		private Index _loadIndexwithCurrentDeleted;

		private int _suspendIndexEvents;

		private bool _inDataLoad;

		private bool _schemaLoading;

		private bool _enforceConstraints;

		internal bool _suspendEnforceConstraints;

		protected internal bool fInitInProgress;

		private bool _inLoad;

		internal bool _fInLoadDiffgram;

		private byte _isTypedDataTable;

		private DataRow[] _emptyDataRowArray;

		private PropertyDescriptorCollection _propertyDescriptorCollectionCache;

		private DataRelation[] _nestedParentRelations;

		internal List<DataColumn> _dependentColumns;

		private bool _mergingData;

		private DataRowChangeEventHandler _onRowChangedDelegate;

		private DataRowChangeEventHandler _onRowChangingDelegate;

		private DataRowChangeEventHandler _onRowDeletingDelegate;

		private DataRowChangeEventHandler _onRowDeletedDelegate;

		private DataColumnChangeEventHandler _onColumnChangedDelegate;

		private DataColumnChangeEventHandler _onColumnChangingDelegate;

		private DataTableClearEventHandler _onTableClearingDelegate;

		private DataTableClearEventHandler _onTableClearedDelegate;

		private DataTableNewRowEventHandler _onTableNewRowDelegate;

		private PropertyChangedEventHandler _onPropertyChangingDelegate;

		private EventHandler _onInitialized;

		private readonly DataRowBuilder _rowBuilder;

		internal readonly List<DataView> _delayedViews;

		private readonly List<DataViewListener> _dataViewListeners;

		internal Hashtable _rowDiffId;

		internal readonly ReaderWriterLockSlim _indexesLock;

		internal int _ukColumnPositionForInference;

		private SerializationFormat _remotingFormat;

		private static int s_objectTypeCount;

		private readonly int _objectID;

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

		internal bool AreIndexEventsSuspended => false;

		[Browsable(false)]
		public bool IsInitialized => false;

		private bool IsTypedDataTable => false;

		internal bool SelfNested => false;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal List<Index> LiveIndexes => null;

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

		internal int UKColumnPositionForInference
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataRelationCollection ChildRelations => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataColumnCollection Columns => null;

		private CompareInfo CompareInfo => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ConstraintCollection Constraints => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataSet DataSet => null;

		[Browsable(false)]
		public DataView DefaultView => null;

		internal string DisplayExpressionInternal => null;

		internal bool EnforceConstraints
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool SuspendEnforceConstraints
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Browsable(false)]
		public PropertyCollection ExtendedProperties => null;

		internal IFormatProvider FormatProvider => null;

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

		[DefaultValue(50)]
		public int MinimumCapacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int RecordCapacity => 0;

		internal int ElementColumnCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataRelationCollection ParentRelations => null;

		internal bool MergingData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal DataRelation[] NestedParentRelations => null;

		internal bool SchemaLoading => false;

		internal int NestedParentsCount => 0;

		[TypeConverter(typeof(PrimaryKeyTypeConverter))]
		public DataColumn[] PrimaryKey
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
		public DataRowCollection Rows => null;

		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.All)]
		public string TableName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string EncodedTableName => null;

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

		internal DataColumn XmlText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal decimal MaxOccurs
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		internal decimal MinOccurs
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		bool IListSource.ContainsListCollection => false;

		internal bool NeedColumnChangeEvents => false;

		internal XmlQualifiedName TypeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Hashtable RowDiffId => null;

		internal int ObjectID => 0;

		public event EventHandler Initialized
		{
			add
			{
			}
			remove
			{
			}
		}

		public DataTable()
		{
		}

		public DataTable(string tableName)
		{
		}

		protected DataTable(SerializationInfo info, StreamingContext context)
		{
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
		}

		internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat)
		{
		}

		internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
		}

		internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable)
		{
		}

		internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
		}

		internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints)
		{
		}

		internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex)
		{
		}

		private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex)
		{
			return default(DataRowState);
		}

		internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
		}

		private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors)
		{
		}

		internal void RestoreIndexEvents(bool forceReset)
		{
		}

		internal void SuspendIndexEvents()
		{
		}

		internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes)
		{
			return false;
		}

		internal bool ShouldSerializeCaseSensitive()
		{
			return false;
		}

		private void ResetConstraints()
		{
		}

		internal void SetDataSet(DataSet dataSet)
		{
		}

		internal void EnableConstraints()
		{
		}

		internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes)
		{
			return false;
		}

		internal bool ShouldSerializeLocale()
		{
			return false;
		}

		internal void CacheNestedParent()
		{
		}

		private DataRelation[] FindNestedParentRelations()
		{
			return null;
		}

		private string GetInheritedNamespace(List<DataTable> visitedTables)
		{
			return null;
		}

		internal bool IsNamespaceInherited()
		{
			return false;
		}

		internal void CheckCascadingNamespaceConflict(string realNamespace)
		{
		}

		internal void CheckNamespaceValidityForNestedRelations(string realNamespace)
		{
		}

		internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable)
		{
		}

		internal void DoRaiseNamespaceChange()
		{
		}

		public virtual void BeginInit()
		{
		}

		public virtual void EndInit()
		{
		}

		internal void SetKeyValues(DataKey key, object[] keyValues, int record)
		{
		}

		internal DataRow FindByIndex(Index ndx, object[] key)
		{
			return null;
		}

		internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx)
		{
			return null;
		}

		private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action)
		{
		}

		internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual DataTable CreateInstance()
		{
			return null;
		}

		public virtual DataTable Clone()
		{
			return null;
		}

		internal DataTable Clone(DataSet cloneDS)
		{
			return null;
		}

		private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable)
		{
			return null;
		}

		private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap)
		{
			return null;
		}

		private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns)
		{
			return null;
		}

		internal void AddRow(DataRow row, int proposedID)
		{
		}

		internal void InsertRow(DataRow row, int proposedID, int pos)
		{
		}

		internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent)
		{
		}

		internal void CheckNotModifying(DataRow row)
		{
		}

		public void Clear()
		{
		}

		internal void Clear(bool clearAll)
		{
		}

		internal void CascadeAll(DataRow row, DataRowAction action)
		{
		}

		internal void CommitRow(DataRow row)
		{
		}

		internal int Compare(string s1, string s2)
		{
			return 0;
		}

		internal int Compare(string s1, string s2, CompareInfo comparer)
		{
			return 0;
		}

		internal int IndexOf(string s1, string s2)
		{
			return 0;
		}

		internal bool IsSuffix(string s1, string s2)
		{
			return false;
		}

		internal void DeleteRow(DataRow row)
		{
		}

		internal string FormatSortString(IndexField[] indexDesc)
		{
			return null;
		}

		internal void FreeRecord(ref int record)
		{
		}

		internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter)
		{
			return null;
		}

		internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
		{
			return null;
		}

		IList IListSource.GetList()
		{
			return null;
		}

		internal List<DataViewListener> GetListeners()
		{
			return null;
		}

		internal int GetSpecialHashCode(string name)
		{
			return 0;
		}

		internal void InsertRow(DataRow row, long proposedID)
		{
		}

		internal int NewRecord()
		{
			return 0;
		}

		internal int NewUninitializedRecord()
		{
			return 0;
		}

		internal int NewRecord(int sourceRecord)
		{
			return 0;
		}

		internal DataRow NewEmptyRow()
		{
			return null;
		}

		private DataRow NewUninitializedRow()
		{
			return null;
		}

		public DataRow NewRow()
		{
			return null;
		}

		internal DataRow CreateEmptyRow()
		{
			return null;
		}

		private void NewRowCreated(DataRow row)
		{
		}

		internal DataRow NewRow(int record)
		{
			return null;
		}

		protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return null;
		}

		protected virtual Type GetRowType()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal DataRow[] NewRowArray(int size)
		{
			return null;
		}

		protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e)
		{
		}

		protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e)
		{
		}

		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		internal void OnRemoveColumnInternal(DataColumn column)
		{
		}

		protected virtual void OnRemoveColumn(DataColumn column)
		{
		}

		private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		protected virtual void OnRowChanged(DataRowChangeEventArgs e)
		{
		}

		protected virtual void OnRowChanging(DataRowChangeEventArgs e)
		{
		}

		protected virtual void OnRowDeleting(DataRowChangeEventArgs e)
		{
		}

		protected virtual void OnRowDeleted(DataRowChangeEventArgs e)
		{
		}

		protected virtual void OnTableCleared(DataTableClearEventArgs e)
		{
		}

		protected virtual void OnTableClearing(DataTableClearEventArgs e)
		{
		}

		protected virtual void OnTableNewRow(DataTableNewRowEventArgs e)
		{
		}

		private void OnInitialized()
		{
		}

		internal IndexField[] ParseSortString(string sortString)
		{
			return null;
		}

		internal void RaisePropertyChanging(string name)
		{
		}

		internal void RecordChanged(int record)
		{
		}

		internal void RecordChanged(int[] oldIndex, int[] newIndex)
		{
		}

		internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
		{
		}

		internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2)
		{
		}

		internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version)
		{
			return null;
		}

		internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version)
		{
			return null;
		}

		internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue)
		{
		}

		internal void RemoveRow(DataRow row, bool check)
		{
		}

		public virtual void Reset()
		{
		}

		internal void ResetIndexes()
		{
		}

		internal void ResetInternalIndexes(DataColumn column)
		{
		}

		internal void RollbackRow(DataRow row)
		{
		}

		private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction)
		{
			return null;
		}

		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent)
		{
			return null;
		}

		internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = DataRowAction.Change, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false)
		{
		}

		private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException)
		{
			deferredException = null;
		}

		internal void SetOldRecord(DataRow row, int proposedRecord)
		{
		}

		private void RestoreShadowIndexes()
		{
		}

		private void SetShadowIndexes()
		{
		}

		internal void ShadowIndexCopy()
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal bool UpdatingCurrent(DataRow row, DataRowAction action)
		{
			return false;
		}

		internal DataColumn AddUniqueKey(int position)
		{
			return null;
		}

		internal DataColumn AddUniqueKey()
		{
			return null;
		}

		internal DataColumn AddForeignKey(DataColumn parentKey)
		{
			return null;
		}

		internal void UpdatePropertyDescriptorCollectionCache()
		{
		}

		internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes)
		{
			return null;
		}

		public void Merge(DataTable table)
		{
		}

		public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction)
		{
		}

		public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy)
		{
		}

		private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy)
		{
			return false;
		}

		private bool CheckForClosureOnExpressionTables(List<DataTable> tableList)
		{
			return false;
		}

		public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy)
		{
		}

		private void RestoreConstraint(bool originalEnforceConstraint)
		{
		}

		private bool IsEmptyXml(XmlReader reader)
		{
			return false;
		}

		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving)
		{
			return default(XmlReadMode);
		}

		internal void ReadEndElement(XmlReader reader)
		{
		}

		internal void ReadXDRSchema(XmlReader reader)
		{
		}

		internal bool MoveToElement(XmlReader reader, int depth)
		{
			return false;
		}

		private void ReadXmlDiffgram(XmlReader reader)
		{
		}

		internal void ReadXSDSchema(XmlReader reader, bool denyResolving)
		{
		}

		internal void ReadXmlSchema(XmlReader reader, bool denyResolving)
		{
		}

		private void CreateTableList(DataTable currentTable, List<DataTable> tableList)
		{
		}

		private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList)
		{
		}

		public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet)
		{
			return null;
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		protected virtual XmlSchema GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		protected virtual void ReadXmlSerializable(XmlReader reader)
		{
		}

		internal void AddDependentColumn(DataColumn expressionColumn)
		{
		}

		internal void RemoveDependentColumn(DataColumn expressionColumn)
		{
		}

		internal void EvaluateExpressions()
		{
		}

		internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows)
		{
		}

		internal void EvaluateExpressions(DataColumn column)
		{
		}

		internal void EvaluateDependentExpressions(DataColumn column)
		{
		}

		internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows)
		{
		}
	}
}
