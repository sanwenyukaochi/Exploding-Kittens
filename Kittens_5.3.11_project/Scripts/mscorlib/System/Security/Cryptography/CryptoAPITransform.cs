using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class CryptoAPITransform : ICryptoTransform, IDisposable
	{
		private bool m_disposed;

		public bool CanReuseTransform => false;

		public bool CanTransformMultipleBlocks => false;

		public int InputBlockSize => 0;

		public IntPtr KeyHandle => (IntPtr)0;

		public int OutputBlockSize => 0;

		internal CryptoAPITransform()
		{
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		private void Dispose(bool disposing)
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

		[ComVisible(false)]
		public void Reset()
		{
		}
	}
}
