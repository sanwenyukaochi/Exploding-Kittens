using System.Collections;

namespace System.ComponentModel
{
	public class ListSortDescriptionCollection : IList, ICollection, IEnumerable
	{
		private ArrayList _sorts;

		public ListSortDescription this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool IList.IsFixedSize => false;

		bool IList.IsReadOnly => false;

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

		public int Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public ListSortDescriptionCollection()
		{
		}

		public ListSortDescriptionCollection(ListSortDescription[] sorts)
		{
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		public bool Contains(object value)
		{
			return false;
		}

		public int IndexOf(object value)
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

		public void CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
