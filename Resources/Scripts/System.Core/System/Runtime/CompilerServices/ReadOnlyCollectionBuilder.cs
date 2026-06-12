using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Runtime.CompilerServices
{
	[Serializable]
	public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
	{
		[Serializable]
		private class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private readonly ReadOnlyCollectionBuilder<T> _builder;

			private readonly int _version;

			private int _index;

			private T _current;

			public T Current => default(T);

			object IEnumerator.Current => null;

			internal Enumerator(ReadOnlyCollectionBuilder<T> builder)
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

		private T[] _items;

		private int _size;

		private int _version;

		public int Capacity
		{
			set
			{
			}
		}

		public int Count => 0;

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

		bool ICollection<T>.IsReadOnly => false;

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

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public ReadOnlyCollectionBuilder()
		{
		}

		public ReadOnlyCollectionBuilder(int capacity)
		{
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Add(T item)
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

		public IEnumerator<T> GetEnumerator()
		{
			return null;
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

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			return null;
		}

		private void EnsureCapacity(int min)
		{
		}

		private static bool IsCompatibleObject(object value)
		{
			return false;
		}

		private static void ValidateNullValue(object value, string argument)
		{
		}
	}
}
