using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace System.Data
{
	[ToolboxItem(false)]
	[DefaultProperty("ColumnName")]
	[DesignTimeVisible(false)]
	public class DataColumn : MarshalByValueComponent
	{
		private bool _allowNull;

		private string _caption;

		private string _columnName;

		private Type _dataType;

		private StorageType _storageType;

		internal object _defaultValue;

		private DataSetDateTime _dateTimeMode;

		private DataExpression _expression;

		private int _maxLength;

		private int _ordinal;

		private bool _readOnly;

		internal Index _sortIndex;

		internal DataTable _table;

		private bool _unique;

		internal MappingType _columnMapping;

		internal int _hashCode;

		internal int _errors;

		private bool _isSqlType;

		private bool _implementsINullable;

		private bool _implementsIChangeTracking;

		private bool _implementsIRevertibleChangeTracking;

		private bool _implementsIXMLSerializable;

		private bool _defaultValueIsNull;

		internal List<DataColumn> _dependentColumns;

		internal PropertyCollection _extendedProperties;

		private DataStorage _storage;

		private AutoIncrementValue _autoInc;

		internal string _columnUri;

		private string _columnPrefix;

		internal string _encodedColumnName;

		internal SimpleType _simpleType;

		private static int s_objectTypeCount;

		private readonly int _objectID;

		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanging;

		[DefaultValue(true)]
		public bool AllowDBNull
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DefaultValue(false)]
		[RefreshProperties(RefreshProperties.All)]
		public bool AutoIncrement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal object AutoIncrementCurrent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal AutoIncrementValue AutoInc => null;

		[DefaultValue(0L)]
		public long AutoIncrementSeed
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DefaultValue(1L)]
		public long AutoIncrementStep
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string Caption
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue(null)]
		public string ColumnName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string EncodedColumnName => null;

		internal IFormatProvider FormatProvider => null;

		internal CultureInfo Locale => null;

		internal int ObjectID => 0;

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

		internal bool Computed => false;

		internal DataExpression DataExpression => null;

		[TypeConverter(typeof(ColumnTypeConverter))]
		[DefaultValue(/*Could not decode attribute arguments.*/)]
		[RefreshProperties(RefreshProperties.All)]
		public Type DataType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(DataSetDateTime.UnspecifiedLocal)]
		[RefreshProperties(RefreshProperties.All)]
		public DataSetDateTime DateTimeMode
		{
			get
			{
				return default(DataSetDateTime);
			}
			set
			{
			}
		}

		[TypeConverter(typeof(DefaultValueTypeConverter))]
		public object DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool DefaultValueIsNull => false;

		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue(null)]
		public string Expression
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

		internal bool HasData => false;

		internal bool ImplementsINullable => false;

		internal bool ImplementsIChangeTracking => false;

		internal bool ImplementsIRevertibleChangeTracking => false;

		internal bool IsValueType => false;

		internal bool IsSqlType => false;

		[DefaultValue(-1)]
		public int MaxLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int Ordinal => 0;

		[DefaultValue(false)]
		public bool ReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Index SortIndex => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DataTable Table => null;

		internal object this[int record]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Unique
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal string XmlDataType { get; set; }

		internal SimpleType SimpleType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(MappingType.Element)]
		public virtual MappingType ColumnMapping
		{
			get
			{
				return default(MappingType);
			}
			set
			{
			}
		}

		internal bool IsCustomType => false;

		internal bool ImplementsIXMLSerializable => false;

		public DataColumn()
		{
		}

		public DataColumn(string columnName, Type dataType)
		{
		}

		public DataColumn(string columnName, Type dataType, string expr, MappingType type)
		{
		}

		private void UpdateColumnType(Type type, StorageType typeCode)
		{
		}

		internal string GetColumnValueAsString(DataRow row, DataRowVersion version)
		{
			return null;
		}

		internal void BindExpression()
		{
		}

		private void SetMaxLengthSimpleType()
		{
		}

		internal void SetOrdinalInternal(int ordinal)
		{
		}

		internal void SetTable(DataTable table)
		{
		}

		private DataRow GetDataRow(int index)
		{
			return null;
		}

		internal void InitializeRecord(int record)
		{
		}

		internal void SetValue(int record, object value)
		{
		}

		internal void FreeRecord(int record)
		{
		}

		internal void InternalUnique(bool value)
		{
		}

		internal void CheckColumnConstraint(DataRow row, DataRowAction action)
		{
		}

		internal bool CheckMaxLength()
		{
			return false;
		}

		internal void CheckMaxLength(DataRow dr)
		{
		}

		protected internal void CheckNotAllowNull()
		{
		}

		internal void CheckNullable(DataRow row)
		{
		}

		protected void CheckUnique()
		{
		}

		internal int Compare(int record1, int record2)
		{
			return 0;
		}

		internal bool CompareValueTo(int record1, object value, bool checkType)
		{
			return false;
		}

		internal int CompareValueTo(int record1, object value)
		{
			return 0;
		}

		internal object ConvertValue(object value)
		{
			return null;
		}

		internal void Copy(int srcRecordNo, int dstRecordNo)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DataColumn Clone()
		{
			return null;
		}

		internal object GetAggregateValue(int[] records, AggregateType kind)
		{
			return null;
		}

		private int GetStringLength(int record)
		{
			return 0;
		}

		internal void Init(int record)
		{
		}

		internal static bool IsAutoIncrementType(Type dataType)
		{
			return false;
		}

		internal bool IsValueCustomTypeInstance(object value)
		{
			return false;
		}

		internal bool IsInRelation()
		{
			return false;
		}

		internal bool IsMaxLengthViolated()
		{
			return false;
		}

		internal bool IsNotAllowDBNullViolated()
		{
			return false;
		}

		internal void FinishInitInProgress()
		{
		}

		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent)
		{
		}

		protected internal void RaisePropertyChanging(string name)
		{
		}

		private void InsureStorage()
		{
		}

		internal void SetCapacity(int capacity)
		{
		}

		internal void OnSetDataSet()
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal object ConvertXmlToObject(string s)
		{
			return null;
		}

		internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			return null;
		}

		internal string ConvertObjectToXml(object value)
		{
			return null;
		}

		internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
		}

		internal object GetEmptyColumnStore(int recordCount)
		{
			return null;
		}

		internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex)
		{
		}

		internal void SetStorage(object store, BitArray nullbits)
		{
		}

		internal void AddDependentColumn(DataColumn expressionColumn)
		{
		}

		internal void RemoveDependentColumn(DataColumn expressionColumn)
		{
		}

		internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression)
		{
		}
	}
}
