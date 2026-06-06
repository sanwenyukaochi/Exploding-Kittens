using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data
{
	[DefaultProperty("Table")]
	[DefaultEvent("PositionChanged")]
	public class DataView : MarshalByValueComponent, IBindingListView, IBindingList, IList, ICollection, IEnumerable, ITypedList, ISupportInitializeNotification, ISupportInitialize
	{
		private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
		{
			internal static readonly DataRowReferenceComparer s_default;

			private DataRowReferenceComparer()
			{
			}

			public bool Equals(DataRow x, DataRow y)
			{
				return false;
			}

			public int GetHashCode(DataRow obj)
			{
				return 0;
			}
		}

		private DataViewManager _dataViewManager;

		private DataTable _table;

		private bool _locked;

		private Index _index;

		private Dictionary<string, Index> _findIndexes;

		private string _sort;

		private Comparison<DataRow> _comparison;

		private IFilter _rowFilter;

		private DataViewRowState _recordStates;

		private bool _shouldOpen;

		private bool _open;

		private bool _allowNew;

		private bool _allowEdit;

		private bool _allowDelete;

		private bool _applyDefaultSort;

		internal DataRow _addNewRow;

		private ListChangedEventArgs _addNewMoved;

		private ListChangedEventHandler _onListChanged;

		internal static ListChangedEventArgs s_resetEventArgs;

		private DataTable _delayedTable;

		private string _delayedRowFilter;

		private string _delayedSort;

		private DataViewRowState _delayedRecordStates;

		private bool _fInitInProgress;

		private bool _fEndInitInProgress;

		private Dictionary<DataRow, DataRowView> _rowViewCache;

		private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer;

		private DataViewListener _dvListener;

		private static int s_objectTypeCount;

		private readonly int _objectID;

		[DefaultValue(true)]
		public bool AllowDelete => false;

		[DefaultValue(true)]
		public bool AllowEdit => false;

		[DefaultValue(true)]
		public bool AllowNew => false;

		[Browsable(false)]
		public int Count => 0;

		private int CountFromIndex => 0;

		[Browsable(false)]
		public DataViewManager DataViewManager => null;

		[Browsable(false)]
		public bool IsInitialized => false;

		[Browsable(false)]
		protected bool IsOpen => false;

		bool ICollection.IsSynchronized => false;

		[DefaultValue(null)]
		public virtual string RowFilter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(DataViewRowState.CurrentRows)]
		public DataViewRowState RowStateFilter
		{
			get
			{
				return default(DataViewRowState);
			}
			set
			{
			}
		}

		[DefaultValue(null)]
		public string Sort
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Comparison<DataRow> SortComparison => null;

		object ICollection.SyncRoot => null;

		[TypeConverter(typeof(DataTableTypeConverter))]
		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.All)]
		public DataTable Table
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		object IList.this[int recordIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DataRowView this[int recordIndex] => null;

		bool IList.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		bool IBindingList.AllowNew => false;

		bool IBindingList.AllowEdit => false;

		bool IBindingList.AllowRemove => false;

		bool IBindingList.SupportsChangeNotification => false;

		bool IBindingList.SupportsSearching => false;

		bool IBindingList.SupportsSorting => false;

		bool IBindingList.IsSorted => false;

		PropertyDescriptor IBindingList.SortProperty => null;

		ListSortDirection IBindingList.SortDirection => default(ListSortDirection);

		string IBindingListView.Filter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		ListSortDescriptionCollection IBindingListView.SortDescriptions => null;

		bool IBindingListView.SupportsAdvancedSorting => false;

		bool IBindingListView.SupportsFiltering => false;

		internal int ObjectID => 0;

		public event ListChangedEventHandler ListChanged
		{
			add
			{
			}
			remove
			{
			}
		}

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

		internal DataView(DataTable table, bool locked)
		{
		}

		public DataView(DataTable table)
		{
		}

		public virtual DataRowView AddNew()
		{
			return null;
		}

		public void BeginInit()
		{
		}

		public void EndInit()
		{
		}

		private void CheckOpen()
		{
		}

		private void CheckSort(string sort)
		{
		}

		protected void Close()
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		private void CopyTo(DataRowView[] array, int index)
		{
		}

		public void Delete(int index)
		{
		}

		internal void Delete(DataRow row)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal void FinishAddNew(bool success)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		internal int IndexOf(DataRowView rowview)
		{
			return 0;
		}

		private int IndexOfDataRowView(DataRowView rowview)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		internal Index GetFindIndex(string column, bool keepIndex)
		{
			return null;
		}

		object IBindingList.AddNew()
		{
			return null;
		}

		internal PropertyDescriptor GetSortProperty()
		{
			return null;
		}

		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			return 0;
		}

		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		void IBindingList.RemoveSort()
		{
		}

		void IBindingListView.ApplySort(ListSortDescriptionCollection sorts)
		{
		}

		private string CreateSortString(PropertyDescriptor property, ListSortDirection direction)
		{
			return null;
		}

		void IBindingListView.RemoveFilter()
		{
		}

		internal ListSortDescriptionCollection GetSortDescriptions()
		{
			return null;
		}

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		internal virtual IFilter GetFilter()
		{
			return null;
		}

		private int GetRecord(int recordIndex)
		{
			return 0;
		}

		internal DataRow GetRow(int index)
		{
			return null;
		}

		private DataRowView GetRowView(int record)
		{
			return null;
		}

		private DataRowView GetRowView(DataRow dr)
		{
			return null;
		}

		protected virtual void IndexListChanged(object sender, ListChangedEventArgs e)
		{
		}

		internal void IndexListChangedInternal(ListChangedEventArgs e)
		{
		}

		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		private void OnInitialized()
		{
		}

		protected void Reset()
		{
		}

		internal void ResetRowViewCache()
		{
		}

		internal void SetDataViewManager(DataViewManager dataViewManager)
		{
		}

		internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
		}

		internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent)
		{
		}

		protected void UpdateIndex()
		{
		}

		protected virtual void UpdateIndex(bool force)
		{
		}

		internal void UpdateIndex(bool force, bool fireEvent)
		{
		}

		internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e)
		{
		}
	}
}
