namespace System.Security.Cryptography.X509Certificates
{
	public class X509Chain : IDisposable
	{
		private X509ChainImpl impl;

		internal X509ChainImpl Impl => null;

		public X509ChainElementCollection ChainElements => null;

		public X509ChainPolicy ChainPolicy => null;

		public X509Chain()
		{
		}

		public X509Chain(bool useMachineContext)
		{
		}

		internal X509Chain(X509ChainImpl impl)
		{
		}

		[System.MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
		public X509Chain(IntPtr chainContext)
		{
		}

		[System.MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public bool Build(X509Certificate2 certificate)
		{
			return false;
		}

		public void Reset()
		{
		}

		public static X509Chain Create()
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~X509Chain()
		{
		}
	}
}
