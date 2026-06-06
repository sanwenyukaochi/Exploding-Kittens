using System.Collections;

namespace System.ComponentModel
{
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		private class ArraySubsetEnumerator : IEnumerator
		{
			private readonly Array _array;

			private readonly int _total;

			private int _current;

			public object Current => null;

			public ArraySubsetEnumerator(Array array, int count)
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

		private EventDescriptor[] _events;

		private string[] _namedSort;

		private readonly IComparer _comparer;

		private bool _eventsOwned;

		private bool _needSort;

		private readonly bool _readOnly;

		public static readonly EventDescriptorCollection Empty;

		public int Count { get; private set; }

		public virtual EventDescriptor this[int index] => null;

		public virtual EventDescriptor this[string name] => null;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		int ICollection.Count => 0;

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

		bool IList.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		public EventDescriptorCollection(EventDescriptor[] events)
		{
		}

		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		{
		}

		private EventDescriptorCollection(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer)
		{
		}

		public int Add(EventDescriptor value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public bool Contains(EventDescriptor value)
		{
			return false;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		private void EnsureEventsOwned()
		{
		}

		private void EnsureSize(int sizeNeeded)
		{
		}

		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			return null;
		}

		public int IndexOf(EventDescriptor value)
		{
			return 0;
		}

		public void Insert(int index, EventDescriptor value)
		{
		}

		public void Remove(EventDescriptor value)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual EventDescriptorCollection Sort()
		{
			return null;
		}

		public virtual EventDescriptorCollection Sort(string[] names)
		{
			return null;
		}

		public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			return null;
		}

		public virtual EventDescriptorCollection Sort(IComparer comparer)
		{
			return null;
		}

		protected void InternalSort(string[] names)
		{
		}

		protected void InternalSort(IComparer sorter)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		void IList.Clear()
		{
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
	}
}
