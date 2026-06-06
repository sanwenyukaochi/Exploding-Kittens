using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data
{
	[DefaultEvent("CollectionChanged")]
	public sealed class DataColumnCollection : InternalDataCollectionBase
	{
		private readonly DataTable _table;

		private readonly ArrayList _list;

		private int _defaultNameIndex;

		private DataColumn[] _delayedAddRangeColumns;

		private readonly Dictionary<string, DataColumn> _columnFromName;

		private bool _fInClear;

		private DataColumn[] _columnsImplementingIChangeTracking;

		private int _nColumnsImplementingIChangeTracking;

		private int _nColumnsImplementingIRevertibleChangeTracking;

		[CompilerGenerated]
		private CollectionChangeEventHandler CollectionChanging;

		protected override ArrayList List => null;

		internal DataColumn[] ColumnsImplementingIChangeTracking => null;

		internal int ColumnsImplementingIChangeTrackingCount => 0;

		internal int ColumnsImplementingIRevertibleChangeTrackingCount => 0;

		public DataColumn this[int index] => null;

		public DataColumn this[string name] => null;

		internal DataColumn this[string name, string ns] => null;

		public event CollectionChangeEventHandler CollectionChanged
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

		internal event CollectionChangeEventHandler ColumnPropertyChanged
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

		internal DataColumnCollection(DataTable table)
		{
		}

		public void Add(DataColumn column)
		{
		}

		internal void AddAt(int index, DataColumn column)
		{
		}

		private void ArrayAdd(DataColumn column)
		{
		}

		private void ArrayAdd(int index, DataColumn column)
		{
		}

		private void ArrayRemove(DataColumn column)
		{
		}

		internal string AssignName()
		{
			return null;
		}

		private void BaseAdd(DataColumn column)
		{
		}

		private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength)
		{
		}

		private void BaseRemove(DataColumn column)
		{
		}

		internal bool CanRemove(DataColumn column, bool fThrowException)
		{
			return false;
		}

		private void CheckIChangeTracking(DataColumn column)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(string name)
		{
			return false;
		}

		internal bool Contains(string name, bool caseSensitive)
		{
			return false;
		}

		public int IndexOf(string columnName)
		{
			return 0;
		}

		internal int IndexOfCaseInsensitive(string name)
		{
			return 0;
		}

		internal void FinishInitCollection()
		{
		}

		private string MakeName(int index)
		{
			return null;
		}

		private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
		}

		private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
		}

		internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent)
		{
		}

		internal void RegisterColumnName(string name, DataColumn column)
		{
		}

		internal bool CanRegisterName(string name)
		{
			return false;
		}

		public void Remove(DataColumn column)
		{
		}

		internal void UnregisterName(string name)
		{
		}

		private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
		}

		private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
		}
	}
}
