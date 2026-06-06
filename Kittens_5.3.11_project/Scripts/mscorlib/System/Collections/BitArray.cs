namespace System.Collections
{
	[Serializable]
	public sealed class BitArray : ICollection, IEnumerable, ICloneable
	{
		[Serializable]
		private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
		{
			private BitArray bitarray;

			private int index;

			private int version;

			private bool currentElement;

			public virtual object Current => null;

			internal BitArrayEnumeratorSimple(BitArray bitarray)
			{
			}

			public object Clone()
			{
				return null;
			}

			public virtual bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private int[] m_array;

		private int m_length;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		public bool this[int index]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Length
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

		public object SyncRoot => null;

		public bool IsSynchronized => false;

		public BitArray(int length)
		{
		}

		public BitArray(int length, bool defaultValue)
		{
		}

		public BitArray(BitArray bits)
		{
		}

		public bool Get(int index)
		{
			return false;
		}

		public void Set(int index, bool value)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public object Clone()
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		private static int GetArrayLength(int n, int div)
		{
			return 0;
		}
	}
}
