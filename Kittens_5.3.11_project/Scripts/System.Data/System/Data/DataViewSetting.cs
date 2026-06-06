using System.ComponentModel;

namespace System.Data
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class DataViewSetting
	{
		private DataViewManager _dataViewManager;

		private DataTable _table;

		private string _sort;

		private string _rowFilter;

		private DataViewRowState _rowStateFilter;

		private bool _applyDefaultSort;

		public bool ApplyDefaultSort => false;

		public string RowFilter => null;

		public DataViewRowState RowStateFilter => default(DataViewRowState);

		public string Sort => null;

		internal DataViewSetting()
		{
		}

		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
		}

		internal void SetDataTable(DataTable table)
		{
		}
	}
}
