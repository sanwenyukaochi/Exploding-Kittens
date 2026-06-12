using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
	[Serializable]
	[DebuggerTypeProxy(typeof(DictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		[Serializable]
		private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private readonly IDictionary<TKey, TValue> _dictionary;

			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;

			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Key => null;

			public object Value => null;

			public object Current => null;

			public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary)
			{
				_dictionary = null;
				_enumerator = null;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		[Serializable]
		[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			private readonly ICollection<TKey> _collection;

			[NonSerialized]
			private object _syncRoot;

			public int Count => 0;

			bool ICollection<TKey>.IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			internal KeyCollection(ICollection<TKey> collection)
			{
			}

			void ICollection<TKey>.Add(TKey item)
			{
			}

			void ICollection<TKey>.Clear()
			{
			}

			bool ICollection<TKey>.Contains(TKey item)
			{
				return false;
			}

			public void CopyTo(TKey[] array, int arrayIndex)
			{
			}

			bool ICollection<TKey>.Remove(TKey item)
			{
				return false;
			}

			public IEnumerator<TKey> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			internal KeyCollection()
			{
			}
		}

		[Serializable]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			private readonly ICollection<TValue> _collection;

			[NonSerialized]
			private object _syncRoot;

			public int Count => 0;

			bool ICollection<TValue>.IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			internal ValueCollection(ICollection<TValue> collection)
			{
			}

			void ICollection<TValue>.Add(TValue item)
			{
			}

			void ICollection<TValue>.Clear()
			{
			}

			bool ICollection<TValue>.Contains(TValue item)
			{
				return false;
			}

			public void CopyTo(TValue[] array, int arrayIndex)
			{
			}

			bool ICollection<TValue>.Remove(TValue item)
			{
				return false;
			}

			public IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			internal ValueCollection()
			{
			}
		}

		private readonly IDictionary<TKey, TValue> m_dictionary;

		[NonSerialized]
		private object _syncRoot;

		[NonSerialized]
		private KeyCollection _keys;

		[NonSerialized]
		private ValueCollection _values;

		public KeyCollection Keys => null;

		public ValueCollection Values => null;

		ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

		ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

		public TValue this[TKey key] => default(TValue);

		TValue IDictionary<TKey, TValue>.this[TKey key]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public int Count => 0;

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

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

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

		IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
		{
		}

		bool IDictionary<TKey, TValue>.Remove(TKey key)
		{
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Clear()
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private static bool IsCompatibleKey(object key)
		{
			return false;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		void IDictionary.Clear()
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

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
