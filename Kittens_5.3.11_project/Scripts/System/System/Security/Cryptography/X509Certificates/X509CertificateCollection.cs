using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		public class X509CertificateEnumerator : IEnumerator
		{
			private IEnumerator enumerator;

			public X509Certificate Current => null;

			object IEnumerator.Current => null;

			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		public X509Certificate this[int index] => null;

		public X509CertificateCollection()
		{
		}

		public X509CertificateCollection(X509CertificateCollection value)
		{
		}

		public void AddRange(X509CertificateCollection value)
		{
		}

		public new X509CertificateEnumerator GetEnumerator()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
