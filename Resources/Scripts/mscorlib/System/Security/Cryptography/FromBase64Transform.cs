using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class FromBase64Transform : ICryptoTransform, IDisposable
	{
		private byte[] _inputBuffer;

		private int _inputIndex;

		private FromBase64TransformMode _whitespaces;

		public int InputBlockSize => 0;

		public int OutputBlockSize => 0;

		public bool CanTransformMultipleBlocks => false;

		public virtual bool CanReuseTransform => false;

		public FromBase64Transform()
		{
		}

		public FromBase64Transform(FromBase64TransformMode whitespaces)
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

		private byte[] DiscardWhiteSpaces(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void Reset()
		{
		}

		public void Clear()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		~FromBase64Transform()
		{
		}
	}
}
