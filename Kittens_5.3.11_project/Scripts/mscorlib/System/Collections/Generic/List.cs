using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private List<T> _list;

			private int _index;

			private int _version;

			private T _current;

			public T Current => default(T);

			object IEnumerator.Current => null;

			internal Enumerator(List<T> list)
			{
				_list = null;
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

			private bool MoveNextRare()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		private const int DefaultCapacity = 4;

		private T[] _items;

		private int _size;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		private static readonly T[] s_emptyArray;

		public int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		bool IList.IsFixedSize => false;

		bool ICollection<T>.IsReadOnly => false;

		bool IList.IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

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

		public List()
		{
		}

		public List(int capacity)
		{
		}

		public List(IEnumerable<T> collection)
		{
		}

		private static bool IsCompatibleObject(object value)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(T item)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddWithResize(T item)
		{
		}

		int IList.Add(object item)
		{
			return 0;
		}

		public void AddRange(IEnumerable<T> collection)
		{
		}

		public ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
		{
			return 0;
		}

		public int BinarySearch(T item)
		{
			return 0;
		}

		public int BinarySearch(T item, IComparer<T> comparer)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		bool IList.Contains(object item)
		{
			return false;
		}

		public void CopyTo(T[] array)
		{
		}

		void ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		private void EnsureCapacity(int min)
		{
		}

		public bool Exists(Predicate<T> match)
		{
			return false;
		}

		public T Find(Predicate<T> match)
		{
			return default(T);
		}

		public List<T> FindAll(Predicate<T> match)
		{
			return null;
		}

		public int FindIndex(Predicate<T> match)
		{
			return 0;
		}

		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		public int FindLastIndex(Predicate<T> match)
		{
			return 0;
		}

		public int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			return 0;
		}

		public void ForEach(Action<T> action)
		{
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

		public List<T> GetRange(int index, int count)
		{
			return null;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		int IList.IndexOf(object item)
		{
			return 0;
		}

		public int IndexOf(T item, int index)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		void IList.Insert(int index, object item)
		{
		}

		public void InsertRange(int index, IEnumerable<T> collection)
		{
		}

		public int LastIndexOf(T item)
		{
			return 0;
		}

		public int LastIndexOf(T item, int index, int count)
		{
			return 0;
		}

		public bool Remove(T item)
		{
			return false;
		}

		void IList.Remove(object item)
		{
		}

		public int RemoveAll(Predicate<T> match)
		{
			return 0;
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public void Reverse()
		{
		}

		public void Reverse(int index, int count)
		{
		}

		public void Sort()
		{
		}

		public void Sort(IComparer<T> comparer)
		{
		}

		public void Sort(int index, int count, IComparer<T> comparer)
		{
		}

		public void Sort(Comparison<T> comparison)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public void TrimExcess()
		{
		}

		public bool TrueForAll(Predicate<T> match)
		{
			return false;
		}

		private void AddEnumerable(IEnumerable<T> enumerable)
		{
		}
	}
}
