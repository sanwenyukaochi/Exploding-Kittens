namespace System.Collections.Specialized
{
	[Serializable]
	public class StringCollection : IList, ICollection, IEnumerable
	{
		private readonly ArrayList data;

		public string this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		bool IList.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		public bool IsSynchronized => false;

		public object SyncRoot => null;

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

		public int Add(string value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public bool Contains(string value)
		{
			return false;
		}

		public void CopyTo(string[] array, int index)
		{
		}

		public int IndexOf(string value)
		{
			return 0;
		}

		public void Insert(int index, string value)
		{
		}

		public void Remove(string value)
		{
		}

		public void RemoveAt(int index)
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

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
