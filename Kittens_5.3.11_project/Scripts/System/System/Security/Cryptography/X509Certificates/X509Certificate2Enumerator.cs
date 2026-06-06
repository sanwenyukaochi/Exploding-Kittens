using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509Certificate2Enumerator : IEnumerator
	{
		private IEnumerator enumerator;

		public X509Certificate2 Current => null;

		object IEnumerator.Current => null;

		internal X509Certificate2Enumerator(X509Certificate2Collection collection)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}
}
