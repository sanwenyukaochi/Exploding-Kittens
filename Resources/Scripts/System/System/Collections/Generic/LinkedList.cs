using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	[Serializable]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			private LinkedList<T> _list;

			private LinkedListNode<T> _node;

			private int _version;

			private T _current;

			private int _index;

			public T Current => default(T);

			object IEnumerator.Current => null;

			internal Enumerator(LinkedList<T> list)
			{
				_list = null;
				_node = null;
				_version = 0;
				_current = default(T);
				_index = 0;
			}

			private Enumerator(SerializationInfo info, StreamingContext context)
			{
				_list = null;
				_node = null;
				_version = 0;
				_current = default(T);
				_index = 0;
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

			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
			}

			void IDeserializationCallback.OnDeserialization(object sender)
			{
			}
		}

		internal LinkedListNode<T> head;

		internal int count;

		internal int version;

		private object _syncRoot;

		private SerializationInfo _siInfo;

		private const string VersionName = "Version";

		private const string CountName = "Count";

		private const string ValuesName = "Data";

		public int Count => 0;

		public LinkedListNode<T> First => null;

		bool ICollection<T>.IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public LinkedList()
		{
		}

		protected LinkedList(SerializationInfo info, StreamingContext context)
		{
		}

		void ICollection<T>.Add(T value)
		{
		}

		public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
		{
			return null;
		}

		public LinkedListNode<T> AddFirst(T value)
		{
			return null;
		}

		public LinkedListNode<T> AddLast(T value)
		{
			return null;
		}

		public void AddLast(LinkedListNode<T> node)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T value)
		{
			return false;
		}

		public void CopyTo(T[] array, int index)
		{
		}

		public LinkedListNode<T> Find(T value)
		{
			return null;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		public bool Remove(T value)
		{
			return false;
		}

		public void Remove(LinkedListNode<T> node)
		{
		}

		public void RemoveFirst()
		{
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public virtual void OnDeserialization(object sender)
		{
		}

		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
		}

		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
		}

		internal void InternalRemoveNode(LinkedListNode<T> node)
		{
		}

		internal void ValidateNewNode(LinkedListNode<T> node)
		{
		}

		internal void ValidateNode(LinkedListNode<T> node)
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
