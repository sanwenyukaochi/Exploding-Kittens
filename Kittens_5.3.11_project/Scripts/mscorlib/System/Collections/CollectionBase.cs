namespace System.Collections
{
	[Serializable]
	public abstract class CollectionBase : IList, ICollection, IEnumerable
	{
		private ArrayList _list;

		protected ArrayList InnerList => null;

		protected IList List => null;

		public int Count => 0;

		bool IList.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

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

		public void Clear()
		{
		}

		public void RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Remove(object value)
		{
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		protected virtual void OnSet(int index, object oldValue, object newValue)
		{
		}

		protected virtual void OnInsert(int index, object value)
		{
		}

		protected virtual void OnClear()
		{
		}

		protected virtual void OnRemove(int index, object value)
		{
		}

		protected virtual void OnValidate(object value)
		{
		}

		protected virtual void OnSetComplete(int index, object oldValue, object newValue)
		{
		}

		protected virtual void OnInsertComplete(int index, object value)
		{
		}

		protected virtual void OnClearComplete()
		{
		}

		protected virtual void OnRemoveComplete(int index, object value)
		{
		}
	}
}
