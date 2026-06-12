using System.Collections;
using System.ComponentModel;

namespace System.Data
{
	public class DataRow
	{
		private readonly DataTable _table;

		private readonly DataColumnCollection _columns;

		internal int _oldRecord;

		internal int _newRecord;

		internal int _tempRecord;

		internal long _rowID;

		internal DataRowAction _action;

		internal bool _inChangingEvent;

		internal bool _inDeletingEvent;

		internal bool _inCascade;

		private DataColumn _lastChangedColumn;

		private int _countColumnChange;

		private DataError _error;

		private int _rbTreeNodeId;

		private static int s_objectTypeCount;

		internal readonly int _objectID;

		internal DataColumn LastChangedColumn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool HasPropertyChanged => false;

		internal int RBTreeNodeId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string RowError
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal long rowID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public DataRowState RowState => default(DataRowState);

		public DataTable Table => null;

		public string this[string columnName]
		{
			set
			{
			}
		}

		public object this[DataColumn column]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object this[DataColumn column, DataRowVersion version] => null;

		public object[] ItemArray
		{
			set
			{
			}
		}

		public bool HasErrors => false;

		protected internal DataRow(DataRowBuilder builder)
		{
		}

		private void RowErrorChanged()
		{
		}

		internal void CheckForLoops(DataRelation rel)
		{
		}

		internal int GetNestedParentCount()
		{
			return 0;
		}

		public void AcceptChanges()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void BeginEdit()
		{
		}

		private bool BeginEditInternal()
		{
			return false;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void CancelEdit()
		{
		}

		private void CheckColumn(DataColumn column)
		{
		}

		internal void CheckInTable()
		{
		}

		public void Delete()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndEdit()
		{
		}

		public void SetColumnError(int columnIndex, string error)
		{
		}

		public void SetColumnError(DataColumn column, string error)
		{
		}

		public string GetColumnError(string columnName)
		{
			return null;
		}

		public string GetColumnError(DataColumn column)
		{
			return null;
		}

		public void ClearErrors()
		{
		}

		internal void ClearError(DataColumn column)
		{
		}

		public DataColumn[] GetColumnsInError()
		{
			return null;
		}

		public DataRow[] GetChildRows(DataRelation relation)
		{
			return null;
		}

		public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version)
		{
			return null;
		}

		internal DataColumn GetDataColumn(string columnName)
		{
			return null;
		}

		public DataRow GetParentRow(DataRelation relation)
		{
			return null;
		}

		public DataRow GetParentRow(DataRelation relation, DataRowVersion version)
		{
			return null;
		}

		internal DataRow GetNestedParentRow(DataRowVersion version)
		{
			return null;
		}

		public DataRow[] GetParentRows(DataRelation relation)
		{
			return null;
		}

		public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version)
		{
			return null;
		}

		internal object[] GetColumnValues(DataColumn[] columns)
		{
			return null;
		}

		internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version)
		{
			return null;
		}

		internal object[] GetKeyValues(DataKey key)
		{
			return null;
		}

		internal object[] GetKeyValues(DataKey key, DataRowVersion version)
		{
			return null;
		}

		internal int GetCurrentRecordNo()
		{
			return 0;
		}

		internal int GetDefaultRecord()
		{
			return 0;
		}

		internal int GetOriginalRecordNo()
		{
			return 0;
		}

		private int GetProposedRecordNo()
		{
			return 0;
		}

		internal int GetRecordFromVersion(DataRowVersion version)
		{
			return 0;
		}

		internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState)
		{
			return default(DataRowVersion);
		}

		internal DataViewRowState GetRecordState(int record)
		{
			return default(DataViewRowState);
		}

		internal bool HasKeyChanged(DataKey key)
		{
			return false;
		}

		internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2)
		{
			return false;
		}

		public bool HasVersion(DataRowVersion version)
		{
			return false;
		}

		internal bool HaveValuesChanged(DataColumn[] columns)
		{
			return false;
		}

		internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2)
		{
			return false;
		}

		public void RejectChanges()
		{
		}

		internal void ResetLastChangedColumn()
		{
		}

		internal void SetKeyValues(DataKey key, object[] keyValues)
		{
		}

		internal void SetNestedParentRow(DataRow parentRow, bool setNonNested)
		{
		}

		internal void SetParentRowToDBNull()
		{
		}

		internal void SetParentRowToDBNull(DataRelation relation)
		{
		}

		internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex)
		{
			return 0;
		}
	}
}
