using System.Runtime.Serialization;

namespace System.Collections.Specialized
{
	[Serializable]
	public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		internal class NameObjectEntry
		{
			internal string Key;

			internal object Value;

			internal NameObjectEntry(string name, object value)
			{
			}
		}

		[Serializable]
		internal class NameObjectKeysEnumerator : IEnumerator
		{
			private int _pos;

			private NameObjectCollectionBase _coll;

			private int _version;

			public object Current => null;

			internal NameObjectKeysEnumerator(NameObjectCollectionBase coll)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private bool _readOnly;

		private ArrayList _entriesArray;

		private IEqualityComparer _keyComparer;

		private Hashtable _entriesTable;

		private NameObjectEntry _nullKeyEntry;

		private SerializationInfo _serializationInfo;

		private int _version;

		[NonSerialized]
		private object _syncRoot;

		private static StringComparer defaultComparer;

		protected bool IsReadOnly => false;

		public virtual int Count => 0;

		object ICollection.SyncRoot => null;

		bool ICollection.IsSynchronized => false;

		protected NameObjectCollectionBase()
		{
		}

		protected NameObjectCollectionBase(IEqualityComparer equalityComparer)
		{
		}

		protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
		{
		}

		internal NameObjectCollectionBase(DBNull dummy)
		{
		}

		protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
		{
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public virtual void OnDeserialization(object sender)
		{
		}

		private void Reset()
		{
		}

		private void Reset(int capacity)
		{
		}

		private NameObjectEntry FindEntry(string key)
		{
			return null;
		}

		protected void BaseAdd(string name, object value)
		{
		}

		protected void BaseRemove(string name)
		{
		}

		protected object BaseGet(string name)
		{
			return null;
		}

		protected void BaseSet(string name, object value)
		{
		}

		protected object BaseGet(int index)
		{
			return null;
		}

		protected string BaseGetKey(int index)
		{
			return null;
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
