using System.IO;

namespace System.Security.Cryptography
{
	public abstract class HashAlgorithm : IDisposable, ICryptoTransform
	{
		private bool _disposed;

		protected int HashSizeValue;

		protected internal byte[] HashValue;

		protected int State;

		public virtual int HashSize => 0;

		public virtual byte[] Hash => null;

		public virtual int InputBlockSize => 0;

		public virtual int OutputBlockSize => 0;

		public virtual bool CanTransformMultipleBlocks => false;

		public virtual bool CanReuseTransform => false;

		public static HashAlgorithm Create()
		{
			return null;
		}

		public static HashAlgorithm Create(string hashName)
		{
			return null;
		}

		public byte[] ComputeHash(byte[] buffer)
		{
			return null;
		}

		public bool TryComputeHash(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			return null;
		}

		public byte[] ComputeHash(Stream inputStream)
		{
			return null;
		}

		private byte[] CaptureHashCodeAndReinitialize()
		{
			return null;
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		protected abstract byte[] HashFinal();

		public abstract void Initialize();

		protected virtual void HashCore(ReadOnlySpan<byte> source)
		{
		}

		protected virtual bool TryHashFinal(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}
	}
}
