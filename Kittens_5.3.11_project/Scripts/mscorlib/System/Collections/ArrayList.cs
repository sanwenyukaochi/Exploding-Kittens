using System.Diagnostics;

namespace System.Collections
{
	[Serializable]
	[DebuggerTypeProxy(typeof(ArrayListDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	public class ArrayList : IList, ICollection, IEnumerable, ICloneable
	{
		[Serializable]
		private class IListWrapper : ArrayList
		{
			private IList _list;

			public override int Capacity
			{
				set
				{
				}
			}

			public override int Count => 0;

			public override bool IsReadOnly => false;

			public override bool IsFixedSize => false;

			public override bool IsSynchronized => false;

			public override object this[int index]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public override object SyncRoot => null;

			internal IListWrapper(IList list)
			{
			}

			public override int Add(object obj)
			{
				return 0;
			}

			public override void AddRange(ICollection c)
			{
			}

			public override void Clear()
			{
			}

			public override object Clone()
			{
				return null;
			}

			public override bool Contains(object obj)
			{
				return false;
			}

			public override void CopyTo(Array array, int index)
			{
			}

			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
			}

			public override IEnumerator GetEnumerator()
			{
				return null;
			}

			public override int IndexOf(object value)
			{
				return 0;
			}

			public override void Insert(int index, object obj)
			{
			}

			public override void InsertRange(int index, ICollection c)
			{
			}

			public override void Remove(object value)
			{
			}

			public override void RemoveAt(int index)
			{
			}

			public override void RemoveRange(int index, int count)
			{
			}

			public override void Sort(int index, int count, IComparer comparer)
			{
			}

			public override object[] ToArray()
			{
				return null;
			}

			public override Array ToArray(Type type)
			{
				return null;
			}
		}

		[Serializable]
		private class ReadOnlyArrayList : ArrayList
		{
			private ArrayList _list;

			public override int Count => 0;

			public override bool IsReadOnly => false;

			public override bool IsFixedSize => false;

			public override bool IsSynchronized => false;

			public override object this[int index]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public override object SyncRoot => null;

			public override int Capacity
			{
				set
				{
				}
			}

			internal ReadOnlyArrayList(ArrayList l)
			{
			}

			public override int Add(object obj)
			{
				return 0;
			}

			public override void AddRange(ICollection c)
			{
			}

			public override void Clear()
			{
			}

			public override object Clone()
			{
				return null;
			}

			public override bool Contains(object obj)
			{
				return false;
			}

			public override void CopyTo(Array array, int index)
			{
			}

			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
			}

			public override IEnumerator GetEnumerator()
			{
				return null;
			}

			public override int IndexOf(object value)
			{
				return 0;
			}

			public override void Insert(int index, object obj)
			{
			}

			public override void InsertRange(int index, ICollection c)
			{
			}

			public override void Remove(object value)
			{
			}

			public override void RemoveAt(int index)
			{
			}

			public override void RemoveRange(int index, int count)
			{
			}

			public override void Sort(int index, int count, IComparer comparer)
			{
			}

			public override object[] ToArray()
			{
				return null;
			}

			public override Array ToArray(Type type)
			{
				return null;
			}
		}

		[Serializable]
		private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
		{
			private ArrayList _list;

			private int _index;

			private int _version;

			private object _currentElement;

			private bool _isArrayList;

			private static object s_dummyObject;

			public object Current => null;

			internal ArrayListEnumeratorSimple(ArrayList list)
			{
			}

			public object Clone()
			{
				return null;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		internal class ArrayListDebugView
		{
		}

		private object[] _items;

		private int _size;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		public virtual int Capacity
		{
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual bool IsFixedSize => false;

		public virtual bool IsReadOnly => false;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public virtual object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ArrayList()
		{
		}

		public ArrayList(int capacity)
		{
		}

		public ArrayList(ICollection c)
		{
		}

		public static ArrayList Adapter(IList list)
		{
			return null;
		}

		public virtual int Add(object value)
		{
			return 0;
		}

		public virtual void AddRange(ICollection c)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual object Clone()
		{
			return null;
		}

		public virtual bool Contains(object item)
		{
			return false;
		}

		public virtual void CopyTo(Array array)
		{
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
		{
		}

		private void EnsureCapacity(int min)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual int IndexOf(object value)
		{
			return 0;
		}

		public virtual void Insert(int index, object value)
		{
		}

		public virtual void InsertRange(int index, ICollection c)
		{
		}

		public static ArrayList ReadOnly(ArrayList list)
		{
			return null;
		}

		public virtual void Remove(object obj)
		{
		}

		public virtual void RemoveAt(int index)
		{
		}

		public virtual void RemoveRange(int index, int count)
		{
		}

		public virtual void Sort(IComparer comparer)
		{
		}

		public virtual void Sort(int index, int count, IComparer comparer)
		{
		}

		public virtual object[] ToArray()
		{
			return null;
		}

		public virtual Array ToArray(Type type)
		{
			return null;
		}
	}
}
