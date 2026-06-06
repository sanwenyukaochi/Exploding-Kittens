using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509ExtensionCollection : ICollection, IEnumerable
	{
		private static byte[] Empty;

		private ArrayList _list;

		public int Count => 0;

		public bool IsSynchronized => false;

		public object SyncRoot => null;

		public X509Extension this[string oid] => null;

		public int Add(X509Extension extension)
		{
			return 0;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public X509ExtensionEnumerator GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
