using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data
{
	public class DataViewManager : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList
	{
		private DataViewSettingCollection _dataViewSettingsCollection;

		private DataSet _dataSet;

		private DataViewManagerListItemTypeDescriptor _item;

		private bool _locked;

		internal int _nViews;

		private static NotSupportedException s_notSupported;

		[DefaultValue(null)]
		public DataSet DataSet => null;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataViewSettingCollection DataViewSettings => null;

		int ICollection.Count => 0;

		object ICollection.SyncRoot => null;

		bool ICollection.IsSynchronized => false;

		bool IList.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool IBindingList.AllowNew => false;

		bool IBindingList.AllowEdit => false;

		bool IBindingList.AllowRemove => false;

		bool IBindingList.SupportsChangeNotification => false;

		bool IBindingList.SupportsSearching => false;

		bool IBindingList.SupportsSorting => false;

		bool IBindingList.IsSorted => false;

		PropertyDescriptor IBindingList.SortProperty => null;

		ListSortDirection IBindingList.SortDirection => default(ListSortDirection);

		public event ListChangedEventHandler ListChanged
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

		internal DataViewManager(DataSet dataSet, bool locked)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
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

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		object IBindingList.AddNew()
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

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		public DataView CreateDataView(DataTable table)
		{
			return null;
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}

		protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e)
		{
		}
	}
}
