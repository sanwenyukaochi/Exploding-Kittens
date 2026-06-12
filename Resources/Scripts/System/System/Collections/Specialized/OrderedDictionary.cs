using System.Runtime.Serialization;

namespace System.Collections.Specialized
{
	[Serializable]
	public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private int _objectReturnType;

			private IEnumerator _arrayEnumerator;

			public object Current => null;

			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Key => null;

			public object Value => null;

			internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType)
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

		private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
		{
			private ArrayList _objects;

			private bool _isKeys;

			int ICollection.Count => 0;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys)
			{
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private ArrayList _objectsArray;

		private Hashtable _objectsTable;

		private int _initialCapacity;

		private IEqualityComparer _comparer;

		private bool _readOnly;

		private object _syncRoot;

		private SerializationInfo _siInfo;

		public int Count => 0;

		bool IDictionary.IsFixedSize => false;

		public bool IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		public ICollection Keys => null;

		private ArrayList objectsArray => null;

		private Hashtable objectsTable => null;

		object ICollection.SyncRoot => null;

		public object this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection Values => null;

		public OrderedDictionary()
		{
		}

		public OrderedDictionary(int capacity)
		{
		}

		public OrderedDictionary(int capacity, IEqualityComparer comparer)
		{
		}

		protected OrderedDictionary(SerializationInfo info, StreamingContext context)
		{
		}

		public void Add(object key, object value)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(object key)
		{
			return false;
		}

		public void CopyTo(Array array, int index)
		{
		}

		private int IndexOfKey(object key)
		{
			return 0;
		}

		public void Remove(object key)
		{
		}

		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		protected virtual void OnDeserialization(object sender)
		{
		}
	}
}
