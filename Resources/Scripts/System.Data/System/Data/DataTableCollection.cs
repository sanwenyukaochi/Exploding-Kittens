using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data
{
	[DefaultEvent("CollectionChanged")]
	[ListBindable(false)]
	public sealed class DataTableCollection : InternalDataCollectionBase
	{
		private readonly DataSet _dataSet;

		private readonly ArrayList _list;

		private int _defaultNameIndex;

		private DataTable[] _delayedAddRangeTables;

		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		private static int s_objectTypeCount;

		private readonly int _objectID;

		protected override ArrayList List => null;

		internal int ObjectID => 0;

		public DataTable this[int index] => null;

		public DataTable this[string name] => null;

		public DataTable this[string name, string tableNamespace] => null;

		public event CollectionChangeEventHandler CollectionChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal DataTableCollection(DataSet dataSet)
		{
		}

		internal DataTable GetTable(string name, string ns)
		{
			return null;
		}

		internal DataTable GetTableSmart(string name, string ns)
		{
			return null;
		}

		public void Add(DataTable table)
		{
		}

		private void ArrayAdd(DataTable table)
		{
		}

		internal string AssignName()
		{
			return null;
		}

		private void BaseAdd(DataTable table)
		{
		}

		private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength)
		{
		}

		private void BaseRemove(DataTable table)
		{
		}

		internal bool CanRemove(DataTable table, bool fThrowException)
		{
			return false;
		}

		public void Clear()
		{
		}

		public bool Contains(string name)
		{
			return false;
		}

		internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive)
		{
			return false;
		}

		internal bool Contains(string name, bool caseSensitive)
		{
			return false;
		}

		public int IndexOf(DataTable table)
		{
			return 0;
		}

		public int IndexOf(string tableName)
		{
			return 0;
		}

		internal int IndexOf(string tableName, string tableNamespace, bool chekforNull)
		{
			return 0;
		}

		internal void ReplaceFromInference(List<DataTable> tableList)
		{
		}

		internal int InternalIndexOf(string tableName)
		{
			return 0;
		}

		internal int InternalIndexOf(string tableName, string tableNamespace)
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

		internal void RegisterName(string name, string tbNamespace)
		{
		}

		public void Remove(DataTable table)
		{
		}

		internal void UnregisterName(string name)
		{
		}
	}
}
