using System.Collections;

namespace System.ComponentModel
{
	public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
	{
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private PropertyDescriptorCollection _owner;

			private int _index;

			public object Current => null;

			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Key => null;

			public object Value => null;

			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
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

		public static readonly PropertyDescriptorCollection Empty;

		private IDictionary _cachedFoundProperties;

		private bool _cachedIgnoreCase;

		private PropertyDescriptor[] _properties;

		private readonly string[] _namedSort;

		private readonly IComparer _comparer;

		private bool _propsOwned;

		private bool _needSort;

		private bool _readOnly;

		private readonly object _internalSyncObject;

		public int Count { get; private set; }

		public virtual PropertyDescriptor this[int index] => null;

		public virtual PropertyDescriptor this[string name] => null;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		int ICollection.Count => 0;

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

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

		public PropertyDescriptorCollection(PropertyDescriptor[] properties)
		{
		}

		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
		{
		}

		private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
		{
		}

		public int Add(PropertyDescriptor value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public bool Contains(PropertyDescriptor value)
		{
			return false;
		}

		public void CopyTo(Array array, int index)
		{
		}

		private void EnsurePropsOwned()
		{
		}

		private void EnsureSize(int sizeNeeded)
		{
		}

		public virtual PropertyDescriptor Find(string name, bool ignoreCase)
		{
			return null;
		}

		public int IndexOf(PropertyDescriptor value)
		{
			return 0;
		}

		public void Insert(int index, PropertyDescriptor value)
		{
		}

		public void Remove(PropertyDescriptor value)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public virtual PropertyDescriptorCollection Sort()
		{
			return null;
		}

		public virtual PropertyDescriptorCollection Sort(string[] names)
		{
			return null;
		}

		public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			return null;
		}

		public virtual PropertyDescriptorCollection Sort(IComparer comparer)
		{
			return null;
		}

		protected void InternalSort(string[] names)
		{
		}

		protected void InternalSort(IComparer sorter)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		void IList.Clear()
		{
		}

		void IDictionary.Clear()
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IList.RemoveAt(int index)
		{
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		int IList.Add(object value)
		{
			return 0;
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
	}
}
