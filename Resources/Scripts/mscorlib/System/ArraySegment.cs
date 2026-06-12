using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System
{
	[Serializable]
	[DefaultMember("Item")]
	public readonly struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private readonly T[] _array;

			private readonly int _start;

			private readonly int _end;

			private int _current;

			public T Current => default(T);

			object IEnumerator.Current => null;

			internal Enumerator(ArraySegment<T> arraySegment)
			{
				_array = null;
				_start = 0;
				_end = 0;
				_current = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private readonly T[] _array;

		private readonly int _offset;

		private readonly int _count;

		public static ArraySegment<T> Empty { get; }

		public T[] Array => null;

		public int Offset => 0;

		public int Count => 0;

		T IList<T>.this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		T IReadOnlyList<T>.this[int index] => default(T);

		bool ICollection<T>.IsReadOnly => false;

		public ArraySegment(T[] array)
		{
			_array = null;
			_offset = 0;
			_count = 0;
		}

		public ArraySegment(T[] array, int offset, int count)
		{
			_array = null;
			_offset = 0;
			_count = 0;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void CopyTo(T[] destination, int destinationIndex)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ArraySegment<T> obj)
		{
			return false;
		}

		int IList<T>.IndexOf(T item)
		{
			return 0;
		}

		void IList<T>.Insert(int index, T item)
		{
		}

		void IList<T>.RemoveAt(int index)
		{
		}

		void ICollection<T>.Add(T item)
		{
		}

		void ICollection<T>.Clear()
		{
		}

		bool ICollection<T>.Contains(T item)
		{
			return false;
		}

		bool ICollection<T>.Remove(T item)
		{
			return false;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void ThrowInvalidOperationIfDefault()
		{
		}
	}
}
