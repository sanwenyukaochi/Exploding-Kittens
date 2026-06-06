using System.Diagnostics;

namespace System.Collections
{
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(StackDebugView))]
	public class Stack : ICollection, IEnumerable, ICloneable
	{
		[Serializable]
		private class StackEnumerator : IEnumerator, ICloneable
		{
			private Stack _stack;

			private int _index;

			private int _version;

			private object _currentElement;

			public virtual object Current => null;

			internal StackEnumerator(Stack stack)
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

		internal class StackDebugView
		{
		}

		private object[] _array;

		private int _size;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		private const int _defaultCapacity = 10;

		public virtual int Count => 0;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public Stack()
		{
		}

		public Stack(int initialCapacity)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual object Clone()
		{
			return null;
		}

		public virtual void CopyTo(Array array, int index)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual object Peek()
		{
			return null;
		}

		public virtual object Pop()
		{
			return null;
		}

		public virtual void Push(object obj)
		{
		}
	}
}
