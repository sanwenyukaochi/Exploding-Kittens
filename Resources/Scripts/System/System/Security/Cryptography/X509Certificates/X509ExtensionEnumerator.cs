using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509ExtensionEnumerator : IEnumerator
	{
		private IEnumerator enumerator;

		public X509Extension Current => null;

		object IEnumerator.Current => null;

		internal X509ExtensionEnumerator(ArrayList list)
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
