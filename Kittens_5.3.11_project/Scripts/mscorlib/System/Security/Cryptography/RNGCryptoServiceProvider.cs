namespace System.Security.Cryptography
{
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		private static object _lock;

		private IntPtr _handle;

		static RNGCryptoServiceProvider()
		{
		}

		public RNGCryptoServiceProvider()
		{
		}

		public RNGCryptoServiceProvider(byte[] rgb)
		{
		}

		public RNGCryptoServiceProvider(CspParameters cspParams)
		{
		}

		public RNGCryptoServiceProvider(string str)
		{
		}

		private void Check()
		{
		}

		private static bool RngOpen()
		{
			return false;
		}

		private unsafe static IntPtr RngInitialize(byte* seed, IntPtr seed_length)
		{
			return (IntPtr)0;
		}

		private unsafe static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length)
		{
			return (IntPtr)0;
		}

		private static void RngClose(IntPtr handle)
		{
		}

		public override void GetBytes(byte[] data)
		{
		}

		internal unsafe void GetBytes(byte* data, IntPtr data_length)
		{
		}

		public override void GetNonZeroBytes(byte[] data)
		{
		}

		~RNGCryptoServiceProvider()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
