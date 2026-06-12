using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509Store : IDisposable
	{
		private string _name;

		private StoreLocation _location;

		private X509Certificate2Collection list;

		private OpenFlags _flags;

		private Mono.Security.X509.X509Store store;

		public X509Certificate2Collection Certificates => null;

		private X509Stores Factory => null;

		internal Mono.Security.X509.X509Store Store => null;

		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
		}

		public void Close()
		{
		}

		public void Dispose()
		{
		}

		public void Open(OpenFlags flags)
		{
		}
	}
}
