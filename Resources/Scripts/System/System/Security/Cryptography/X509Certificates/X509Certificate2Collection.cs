namespace System.Security.Cryptography.X509Certificates
{
	public class X509Certificate2Collection : X509CertificateCollection
	{
		private static string[] newline_split;

		public new X509Certificate2 this[int index] => null;

		public X509Certificate2Collection()
		{
		}

		public X509Certificate2Collection(X509Certificate2Collection certificates)
		{
		}

		public int Add(X509Certificate2 certificate)
		{
			return 0;
		}

		[System.MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates)
		{
		}

		public bool Contains(X509Certificate2 certificate)
		{
			return false;
		}

		private string GetKeyIdentifier(X509Certificate2 x)
		{
			return null;
		}

		[System.MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
		public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
		{
			return null;
		}

		public new X509Certificate2Enumerator GetEnumerator()
		{
			return null;
		}
	}
}
