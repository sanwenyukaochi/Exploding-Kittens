using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class RandomNumberGenerator : IDisposable
	{
		public static RandomNumberGenerator Create()
		{
			return null;
		}

		public static RandomNumberGenerator Create(string rngName)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public abstract void GetBytes(byte[] data);

		public virtual void GetBytes(byte[] data, int offset, int count)
		{
		}

		public virtual void GetNonZeroBytes(byte[] data)
		{
		}

		public static void Fill(Span<byte> data)
		{
		}

		internal static void FillSpan(Span<byte> data)
		{
		}

		public virtual void GetBytes(Span<byte> data)
		{
		}

		public virtual void GetNonZeroBytes(Span<byte> data)
		{
		}

		public static int GetInt32(int fromInclusive, int toExclusive)
		{
			return 0;
		}

		public static int GetInt32(int toExclusive)
		{
			return 0;
		}
	}
}
