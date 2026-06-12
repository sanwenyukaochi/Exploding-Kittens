using System.Collections;

namespace System.ComponentModel
{
	public class AttributeCollection : ICollection, IEnumerable
	{
		private struct AttributeEntry
		{
			public Type type;

			public int index;
		}

		public static readonly AttributeCollection Empty;

		private static Hashtable s_defaultAttributes;

		private readonly Attribute[] _attributes;

		private static readonly object s_internalSyncObject;

		private const int FOUND_TYPES_LIMIT = 5;

		private AttributeEntry[] _foundAttributeTypes;

		private int _index;

		protected virtual Attribute[] Attributes => null;

		public int Count => 0;

		public virtual Attribute this[int index] => null;

		public virtual Attribute this[Type attributeType] => null;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		int ICollection.Count => 0;

		public AttributeCollection(params Attribute[] attributes)
		{
		}

		protected AttributeCollection()
		{
		}

		public static AttributeCollection FromExisting(AttributeCollection existing, params Attribute[] newAttributes)
		{
			return null;
		}

		public bool Contains(Attribute attribute)
		{
			return false;
		}

		public bool Contains(Attribute[] attributes)
		{
			return false;
		}

		protected Attribute GetDefaultAttribute(Type attributeType)
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public bool Matches(Attribute attribute)
		{
			return false;
		}

		public bool Matches(Attribute[] attributes)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void CopyTo(Array array, int index)
		{
		}
	}
}
