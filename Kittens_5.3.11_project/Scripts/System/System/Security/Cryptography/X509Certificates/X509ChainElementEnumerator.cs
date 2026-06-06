using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509ChainElementEnumerator : IEnumerator
	{
		private IEnumerator enumerator;

		public X509ChainElement Current => null;

		object IEnumerator.Current => null;

		internal X509ChainElementEnumerator(IEnumerable enumerable)
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
}
