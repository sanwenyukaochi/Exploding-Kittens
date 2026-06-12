using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Concurrent
{
	[Serializable]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		private sealed class Tables
		{
			internal readonly Node[] _buckets;

			internal readonly object[] _locks;

			internal int[] _countPerLock;

			internal Tables(Node[] buckets, object[] locks, int[] countPerLock)
			{
			}
		}

		[Serializable]
		private sealed class Node
		{
			internal readonly TKey _key;

			internal TValue _value;

			internal Node _next;

			internal readonly int _hashcode;

			internal Node(TKey key, TValue value, int hashcode, Node next)
			{
			}
		}

		[Serializable]
		private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;

			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Key => null;

			public object Value => null;

			public object Current => null;

			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
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

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__35 : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private KeyValuePair<TKey, TValue> _003C_003E2__current;

			public ConcurrentDictionary<TKey, TValue> _003C_003E4__this;

			private Node[] _003Cbuckets_003E5__2;

			private int _003Ci_003E5__3;

			private Node _003Ccurrent_003E5__4;

			KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__35(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		private Tables _tables;

		private IEqualityComparer<TKey> _comparer;

		[NonSerialized]
		private readonly bool _growLockArray;

		[NonSerialized]
		private int _budget;

		private KeyValuePair<TKey, TValue>[] _serializationArray;

		private int _serializationConcurrencyLevel;

		private int _serializationCapacity;

		private static readonly bool s_isValueWriteAtomic;

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

		public int Count => 0;

		public ICollection<TKey> Keys => null;

		IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

		public ICollection<TValue> Values => null;

		IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

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

		private static int DefaultConcurrencyLevel => 0;

		private static bool IsValueWriteAtomic()
		{
			return false;
		}

		public ConcurrentDictionary()
		{
		}

		public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
		{
		}

		public bool TryAdd(TKey key, TValue value)
		{
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool TryRemove(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			value = default(TValue);
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		private bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Clear()
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			return null;
		}

		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
		}

		private void CopyToObjects(object[] array, int index)
		{
		}

		[IteratorStateMachine(typeof(ConcurrentDictionary<, >._003CGetEnumerator_003Ed__35))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			resultingValue = default(TValue);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowKeyNotFoundException(object key)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowKeyNullException()
		{
		}

		private int GetCountInternal()
		{
			return 0;
		}

		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			return default(TValue);
		}

		public TValue GetOrAdd(TKey key, TValue value)
		{
			return default(TValue);
		}

		void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
		{
		}

		bool IDictionary<TKey, TValue>.Remove(TKey key)
		{
			return false;
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
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

		void ICollection.CopyTo(Array array, int index)
		{
		}

		private void GrowTable(Tables tables)
		{
		}

		private static int GetBucket(int hashcode, int bucketCount)
		{
			return 0;
		}

		private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			bucketNo = default(int);
			lockNo = default(int);
		}

		private void AcquireAllLocks(ref int locksAcquired)
		{
		}

		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
		}

		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
		}

		private ReadOnlyCollection<TKey> GetKeys()
		{
			return null;
		}

		private ReadOnlyCollection<TValue> GetValues()
		{
			return null;
		}

		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
		}

		[OnSerialized]
		private void OnSerialized(StreamingContext context)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}
	}
}
