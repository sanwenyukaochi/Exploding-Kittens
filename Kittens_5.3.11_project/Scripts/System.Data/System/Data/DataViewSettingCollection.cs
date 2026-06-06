using System.Collections;
using System.ComponentModel;

namespace System.Data
{
	public class DataViewSettingCollection : ICollection, IEnumerable
	{
		private sealed class DataViewSettingsEnumerator : IEnumerator
		{
			private DataViewSettingCollection _dataViewSettings;

			private IEnumerator _tableEnumerator;

			public object Current => null;

			public DataViewSettingsEnumerator(DataViewManager dvm)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private readonly DataViewManager _dataViewManager;

		private readonly Hashtable _list;

		public virtual DataViewSetting this[DataTable table]
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
		public virtual int Count => 0;

		[Browsable(false)]
		public bool IsSynchronized => false;

		[Browsable(false)]
		public object SyncRoot => null;

		internal DataViewSettingCollection(DataViewManager dataViewManager)
		{
		}

		public void CopyTo(Array ar, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		internal void Remove(DataTable table)
		{
		}
	}
}
