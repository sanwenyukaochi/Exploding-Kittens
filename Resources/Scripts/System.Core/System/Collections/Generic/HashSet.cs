using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	[Serializable]
	[DebuggerTypeProxy(typeof(System.Collections.Generic.ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		internal struct Slot
		{
			internal int hashCode;

			internal int next;

			internal T value;
		}

		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private HashSet<T> _set;

			private int _index;

			private int _version;

			private T _current;

			public T Current => default(T);

			object IEnumerator.Current => null;

			internal Enumerator(HashSet<T> set)
			{
				_set = null;
				_index = 0;
				_version = 0;
				_current = default(T);
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

		private const int Lower31BitMask = int.MaxValue;

		private const int StackAllocThreshold = 100;

		private const int ShrinkThreshold = 3;

		private const string CapacityName = "Capacity";

		private const string ElementsName = "Elements";

		private const string ComparerName = "Comparer";

		private const string VersionName = "Version";

		private int[] _buckets;

		private Slot[] _slots;

		private int _count;

		private int _lastIndex;

		private int _freeList;

		private IEqualityComparer<T> _comparer;

		private int _version;

		private SerializationInfo _siInfo;

		public int Count => 0;

		bool ICollection<T>.IsReadOnly => false;

		public IEqualityComparer<T> Comparer => null;

		public HashSet()
		{
		}

		public HashSet(IEqualityComparer<T> comparer)
		{
		}

		public HashSet(int capacity)
		{
		}

		public HashSet(IEnumerable<T> collection)
		{
		}

		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
		}

		protected HashSet(SerializationInfo info, StreamingContext context)
		{
		}

		private void CopyFrom(HashSet<T> source)
		{
		}

		public HashSet(int capacity, IEqualityComparer<T> comparer)
		{
		}

		void ICollection<T>.Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
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

		public virtual void OnDeserialization(object sender)
		{
		}

		public bool Add(T item)
		{
			return false;
		}

		public void UnionWith(IEnumerable<T> other)
		{
		}

		public void CopyTo(T[] array)
		{
		}

		public void CopyTo(T[] array, int arrayIndex, int count)
		{
		}

		public int RemoveWhere(Predicate<T> match)
		{
			return 0;
		}

		public void TrimExcess()
		{
		}

		private int Initialize(int capacity)
		{
			return 0;
		}

		private void IncreaseCapacity()
		{
		}

		private void SetCapacity(int newSize)
		{
		}

		private bool AddIfNotPresent(T value)
		{
			return false;
		}

		private void AddValue(int index, int hashCode, T value)
		{
		}

		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			return false;
		}

		private int InternalGetHashCode(T item)
		{
			return 0;
		}
	}
}
