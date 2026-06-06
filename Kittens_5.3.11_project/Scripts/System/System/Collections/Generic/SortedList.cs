using System.Diagnostics;

namespace System.Collections.Generic
{
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		[Serializable]
		private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			private SortedList<TKey, TValue> _sortedList;

			private TKey _key;

			private TValue _value;

			private int _index;

			private int _version;

			private int _getEnumeratorRetType;

			object IDictionaryEnumerator.Key => null;

			DictionaryEntry IDictionaryEnumerator.Entry => default(DictionaryEntry);

			public KeyValuePair<TKey, TValue> Current => default(KeyValuePair<TKey, TValue>);

			object IEnumerator.Current => null;

			object IDictionaryEnumerator.Value => null;

			internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType)
			{
				_sortedList = null;
				_key = default(TKey);
				_value = default(TValue);
				_index = 0;
				_version = 0;
				_getEnumeratorRetType = 0;
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private SortedList<TKey, TValue> _sortedList;

			private int _index;

			private int _version;

			private TKey _currentKey;

			public TKey Current => default(TKey);

			object IEnumerator.Current => null;

			internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private SortedList<TKey, TValue> _sortedList;

			private int _index;

			private int _version;

			private TValue _currentValue;

			public TValue Current => default(TValue);

			object IEnumerator.Current => null;

			internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
		{
			private SortedList<TKey, TValue> _dict;

			public int Count => 0;

			public bool IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public TKey this[int index]
			{
				get
				{
					return default(TKey);
				}
				set
				{
				}
			}

			internal KeyList(SortedList<TKey, TValue> dictionary)
			{
			}

			public void Add(TKey key)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(TKey key)
			{
				return false;
			}

			public void CopyTo(TKey[] array, int arrayIndex)
			{
			}

			void ICollection.CopyTo(Array array, int arrayIndex)
			{
			}

			public void Insert(int index, TKey value)
			{
			}

			public IEnumerator<TKey> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public int IndexOf(TKey key)
			{
				return 0;
			}

			public bool Remove(TKey key)
			{
				return false;
			}

			public void RemoveAt(int index)
			{
			}
		}

		[Serializable]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
		{
			private SortedList<TKey, TValue> _dict;

			public int Count => 0;

			public bool IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public TValue this[int index]
			{
				get
				{
					return default(TValue);
				}
				set
				{
				}
			}

			internal ValueList(SortedList<TKey, TValue> dictionary)
			{
			}

			public void Add(TValue key)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(TValue value)
			{
				return false;
			}

			public void CopyTo(TValue[] array, int arrayIndex)
			{
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			public void Insert(int index, TValue value)
			{
			}

			public IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public int IndexOf(TValue value)
			{
				return 0;
			}

			public bool Remove(TValue value)
			{
				return false;
			}

			public void RemoveAt(int index)
			{
			}
		}

		private TKey[] keys;

		private TValue[] values;

		private int _size;

		private int version;

		private IComparer<TKey> comparer;

		private KeyList keyList;

		private ValueList valueList;

		[NonSerialized]
		private object _syncRoot;

		public int Capacity
		{
			set
			{
			}
		}

		public IComparer<TKey> Comparer => null;

		public int Count => 0;

		ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

		ICollection IDictionary.Keys => null;

		IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

		ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

		ICollection IDictionary.Values => null;

		IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		bool IDictionary.IsReadOnly => false;

		bool IDictionary.IsFixedSize => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public TValue this[TKey key]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

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

		public SortedList()
		{
		}

		public SortedList(IComparer<TKey> comparer)
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return false;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		private KeyList GetKeyListHelper()
		{
			return null;
		}

		private ValueList GetValueListHelper()
		{
			return null;
		}

		public void Clear()
		{
		}

		bool IDictionary.Contains(object key)
		{
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool ContainsValue(TValue value)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		private void EnsureCapacity(int min)
		{
		}

		private TValue GetByIndex(int index)
		{
			return default(TValue);
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private TKey GetKey(int index)
		{
			return default(TKey);
		}

		public int IndexOfKey(TKey key)
		{
			return 0;
		}

		public int IndexOfValue(TValue value)
		{
			return 0;
		}

		private void Insert(int index, TKey key, TValue value)
		{
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		void IDictionary.Remove(object key)
		{
		}

		private static bool IsCompatibleKey(object key)
		{
			return false;
		}
	}
}
