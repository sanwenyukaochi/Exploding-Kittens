using System.Collections;
using System.Reflection;

namespace System.Diagnostics
{
	[DefaultMember("Item")]
	public class TraceListenerCollection : IList, ICollection, IEnumerable
	{
		private ArrayList list;

		public int Count => 0;

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

		bool IList.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		object ICollection.SyncRoot => null;

		bool ICollection.IsSynchronized => false;

		internal TraceListenerCollection()
		{
		}

		public int Add(TraceListener listener)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		internal void InitializeListener(TraceListener listener)
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
	}
}
