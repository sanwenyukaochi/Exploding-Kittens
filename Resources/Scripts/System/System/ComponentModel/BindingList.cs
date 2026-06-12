using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.ComponentModel
{
	[Serializable]
	public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents
	{
		private int addNewPos;

		private bool raiseListChangedEvents;

		private bool raiseItemChangedEvents;

		[NonSerialized]
		private PropertyDescriptorCollection _itemTypeProperties;

		[NonSerialized]
		private PropertyChangedEventHandler _propertyChangedEventHandler;

		[NonSerialized]
		private AddingNewEventHandler _onAddingNew;

		[NonSerialized]
		private ListChangedEventHandler _onListChanged;

		[NonSerialized]
		private int _lastChangeIndex;

		private bool allowNew;

		private bool allowEdit;

		private bool allowRemove;

		private bool userSetAllowNew;

		private bool ItemTypeHasDefaultConstructor => false;

		public bool RaiseListChangedEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool AddingNewHandled => false;

		public bool AllowNew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool IBindingList.AllowNew => false;

		public bool AllowEdit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool IBindingList.AllowEdit => false;

		public bool AllowRemove
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool IBindingList.AllowRemove => false;

		bool IBindingList.SupportsChangeNotification => false;

		protected virtual bool SupportsChangeNotificationCore => false;

		bool IBindingList.SupportsSearching => false;

		protected virtual bool SupportsSearchingCore => false;

		bool IBindingList.SupportsSorting => false;

		protected virtual bool SupportsSortingCore => false;

		bool IBindingList.IsSorted => false;

		protected virtual bool IsSortedCore => false;

		PropertyDescriptor IBindingList.SortProperty => null;

		protected virtual PropertyDescriptor SortPropertyCore => null;

		ListSortDirection IBindingList.SortDirection => default(ListSortDirection);

		protected virtual ListSortDirection SortDirectionCore => default(ListSortDirection);

		bool IRaiseItemChangedEvents.RaisesItemChangedEvents => false;

		public event AddingNewEventHandler AddingNew
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ListChangedEventHandler ListChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public BindingList()
		{
		}

		public BindingList(IList<T> list)
		{
		}

		private void Initialize()
		{
		}

		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		private object FireAddingNew()
		{
			return null;
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		public void ResetBindings()
		{
		}

		public void ResetItem(int position)
		{
		}

		private void FireListChanged(ListChangedType type, int index)
		{
		}

		protected override void ClearItems()
		{
		}

		protected override void InsertItem(int index, T item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		protected override void SetItem(int index, T item)
		{
		}

		public virtual void CancelNew(int itemIndex)
		{
		}

		public virtual void EndNew(int itemIndex)
		{
		}

		public T AddNew()
		{
			return default(T);
		}

		object IBindingList.AddNew()
		{
			return null;
		}

		protected virtual object AddNewCore()
		{
			return null;
		}

		void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
		{
		}

		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
		}

		void IBindingList.RemoveSort()
		{
		}

		protected virtual void RemoveSortCore()
		{
		}

		int IBindingList.Find(PropertyDescriptor prop, object key)
		{
			return 0;
		}

		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			return 0;
		}

		void IBindingList.AddIndex(PropertyDescriptor prop)
		{
		}

		void IBindingList.RemoveIndex(PropertyDescriptor prop)
		{
		}

		private void HookPropertyChanged(T item)
		{
		}

		private void UnhookPropertyChanged(T item)
		{
		}

		private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}
	}
}
