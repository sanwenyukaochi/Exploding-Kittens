using System.Diagnostics;

namespace System.Collections
{
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(QueueDebugView))]
	public class Queue : ICollection, IEnumerable, ICloneable
	{
		[Serializable]
		private class QueueEnumerator : IEnumerator, ICloneable
		{
			private Queue _q;

			private int _index;

			private int _version;

			private object _currentElement;

			public virtual object Current => null;

			internal QueueEnumerator(Queue q)
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

			public virtual void Reset()
			{
			}
		}

		internal class QueueDebugView
		{
		}

		private object[] _array;

		private int _head;

		private int _tail;

		private int _size;

		private int _growFactor;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		public virtual int Count => 0;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public Queue()
		{
		}

		public Queue(int capacity)
		{
		}

		public Queue(int capacity, float growFactor)
		{
		}

		public Queue(ICollection col)
		{
		}

		public virtual object Clone()
		{
			return null;
		}

		public virtual void CopyTo(Array array, int index)
		{
		}

		public virtual void Enqueue(object obj)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual object Dequeue()
		{
			return null;
		}

		public virtual object Peek()
		{
			return null;
		}

		internal object GetElement(int i)
		{
			return null;
		}

		private void SetCapacity(int capacity)
		{
		}
	}
}
