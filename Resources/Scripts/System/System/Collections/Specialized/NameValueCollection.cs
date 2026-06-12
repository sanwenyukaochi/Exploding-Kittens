using System.Runtime.Serialization;

namespace System.Collections.Specialized
{
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		private string[] _all;

		private string[] _allKeys;

		public string this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NameValueCollection()
		{
		}

		public NameValueCollection(int capacity, IEqualityComparer equalityComparer)
		{
		}

		protected NameValueCollection(SerializationInfo info, StreamingContext context)
		{
		}

		protected void InvalidateCachedArrays()
		{
		}

		private static string GetAsOneString(ArrayList list)
		{
			return null;
		}

		private static string[] GetAsStringArray(ArrayList list)
		{
			return null;
		}

		public virtual void Add(string name, string value)
		{
		}

		public virtual string Get(string name)
		{
			return null;
		}

		public virtual string[] GetValues(string name)
		{
			return null;
		}

		public virtual void Set(string name, string value)
		{
		}

		public virtual void Remove(string name)
		{
		}

		public virtual string Get(int index)
		{
			return null;
		}

		public virtual string GetKey(int index)
		{
			return null;
		}

		internal NameValueCollection(DBNull dummy)
		{
		}
	}
}
