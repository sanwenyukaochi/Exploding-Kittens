using System.Collections;

namespace System.Data
{
	public sealed class DataRowCollection : InternalDataCollectionBase
	{
		private sealed class DataRowTree : RBTree<DataRow>
		{
			internal DataRowTree()
				: base(default(TreeAccessMethod))
			{
			}

			protected override int CompareNode(DataRow record1, DataRow record2)
			{
				return 0;
			}

			protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2)
			{
				return 0;
			}
		}

		private readonly DataTable _table;

		private readonly DataRowTree _list;

		internal int _nullInList;

		public override int Count => 0;

		public DataRow this[int index] => null;

		internal DataRowCollection(DataTable table)
		{
		}

		public void Add(DataRow row)
		{
		}

		internal void DiffInsertAt(DataRow row, int pos)
		{
		}

		public int IndexOf(DataRow row)
		{
			return 0;
		}

		internal DataRow AddWithColumnEvents(params object[] values)
		{
			return null;
		}

		internal void ArrayAdd(DataRow row)
		{
		}

		internal void ArrayInsert(DataRow row, int pos)
		{
		}

		internal void ArrayClear()
		{
		}

		internal void ArrayRemove(DataRow row)
		{
		}

		public override void CopyTo(Array ar, int index)
		{
		}

		public void CopyTo(DataRow[] array, int index)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
