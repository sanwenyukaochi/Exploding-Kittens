using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509ChainElementCollection : ICollection, IEnumerable
	{
		private ArrayList _list;

		public int Count => 0;

		public bool IsSynchronized => false;

		public X509ChainElement this[int index] => null;

		public object SyncRoot => null;

		internal X509ChainElementCollection()
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public X509ChainElementEnumerator GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal void Add(X509Certificate2 certificate)
		{
		}

		internal void Clear()
		{
		}

		internal bool Contains(X509Certificate2 certificate)
		{
			return false;
		}
	}
}
