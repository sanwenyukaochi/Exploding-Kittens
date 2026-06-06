using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(SortedListDebugView))]
	public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
	{
		[Serializable]
		private class SyncSortedList : SortedList
		{
			private SortedList _list;

			private object _root;

			public override int Count => 0;

			public override object SyncRoot => null;

			public override bool IsReadOnly => false;

			public override bool IsFixedSize => false;

			public override bool IsSynchronized => false;

			public override object this[object key]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal SyncSortedList(SortedList list)
			{
			}

			public override void Add(object key, object value)
			{
			}

			public override void Clear()
			{
			}

			public override object Clone()
			{
				return null;
			}

			public override bool Contains(object key)
			{
				return false;
			}

			public override bool ContainsKey(object key)
			{
				return false;
			}

			public override bool ContainsValue(object key)
			{
				return false;
			}

			public override void CopyTo(Array array, int index)
			{
			}

			public override object GetByIndex(int index)
			{
				return null;
			}

			public override IDictionaryEnumerator GetEnumerator()
			{
				return null;
			}

			public override object GetKey(int index)
			{
				return null;
			}

			public override IList GetKeyList()
			{
				return null;
			}

			public override IList GetValueList()
			{
				return null;
			}

			public override int IndexOfKey(object key)
			{
				return 0;
			}

			public override int IndexOfValue(object value)
			{
				return 0;
			}

			public override void RemoveAt(int index)
			{
			}

			public override void Remove(object key)
			{
			}
		}

		[Serializable]
		private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
		{
			private SortedList _sortedList;

			private object _key;

			private object _value;

			private int _index;

			private int _startIndex;

			private int _endIndex;

			private int _version;

			private bool _current;

			private int _getObjectRetType;

			public virtual object Key => null;

			public virtual DictionaryEntry Entry => default(DictionaryEntry);

			public virtual object Current => null;

			public virtual object Value => null;

			internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
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

		[Serializable]
		[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private class KeyList : IList, ICollection, IEnumerable
		{
			private SortedList sortedList;

			public virtual int Count => 0;

			public virtual bool IsReadOnly => false;

			public virtual bool IsFixedSize => false;

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

			internal KeyList(SortedList sortedList)
			{
			}

			public virtual int Add(object key)
			{
				return 0;
			}

			public virtual void Clear()
			{
			}

			public virtual bool Contains(object key)
			{
				return false;
			}

			public virtual void CopyTo(Array array, int arrayIndex)
			{
			}

			public virtual void Insert(int index, object value)
			{
			}

			public virtual IEnumerator GetEnumerator()
			{
				return null;
			}

			public virtual int IndexOf(object key)
			{
				return 0;
			}

			public virtual void Remove(object key)
			{
			}

			public virtual void RemoveAt(int index)
			{
			}
		}

		[Serializable]
		[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private class ValueList : IList, ICollection, IEnumerable
		{
			private SortedList sortedList;

			public virtual int Count => 0;

			public virtual bool IsReadOnly => false;

			public virtual bool IsFixedSize => false;

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

			internal ValueList(SortedList sortedList)
			{
			}

			public virtual int Add(object key)
			{
				return 0;
			}

			public virtual void Clear()
			{
			}

			public virtual bool Contains(object value)
			{
				return false;
			}

			public virtual void CopyTo(Array array, int arrayIndex)
			{
			}

			public virtual void Insert(int index, object value)
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

			public virtual void Remove(object value)
			{
			}

			public virtual void RemoveAt(int index)
			{
			}
		}

		internal class SortedListDebugView
		{
		}

		private object[] keys;

		private object[] values;

		private int _size;

		private int version;

		private IComparer comparer;

		private KeyList keyList;

		private ValueList valueList;

		[NonSerialized]
		private object _syncRoot;

		public virtual int Capacity
		{
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual ICollection Keys => null;

		public virtual ICollection Values => null;

		public virtual bool IsReadOnly => false;

		public virtual bool IsFixedSize => false;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public virtual object this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SortedList()
		{
		}

		private void Init()
		{
		}

		public SortedList(int initialCapacity)
		{
		}

		public SortedList(IComparer comparer)
		{
		}

		public virtual void Add(object key, object value)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual object Clone()
		{
			return null;
		}

		public virtual bool Contains(object key)
		{
			return false;
		}

		public virtual bool ContainsKey(object key)
		{
			return false;
		}

		public virtual bool ContainsValue(object value)
		{
			return false;
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		private void EnsureCapacity(int min)
		{
		}

		public virtual object GetByIndex(int index)
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual object GetKey(int index)
		{
			return null;
		}

		public virtual IList GetKeyList()
		{
			return null;
		}

		public virtual IList GetValueList()
		{
			return null;
		}

		public virtual int IndexOfKey(object key)
		{
			return 0;
		}

		public virtual int IndexOfValue(object value)
		{
			return 0;
		}

		private void Insert(int index, object key, object value)
		{
		}

		public virtual void RemoveAt(int index)
		{
		}

		public virtual void Remove(object key)
		{
		}

		public static SortedList Synchronized(SortedList list)
		{
			return null;
		}
	}
}
