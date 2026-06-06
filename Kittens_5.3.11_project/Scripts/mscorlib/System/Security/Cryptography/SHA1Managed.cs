using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class SHA1Managed : SHA1
	{
		private byte[] _buffer;

		private long _count;

		private uint[] _stateSHA1;

		private uint[] _expandedBuffer;

		public override void Initialize()
		{
		}

		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		protected override byte[] HashFinal()
		{
			return null;
		}

		private void InitializeState()
		{
		}

		private void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
		}

		private byte[] _EndHash()
		{
			return null;
		}

		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
		}

		private unsafe static void SHAExpand(uint* x)
		{
		}
	}
}
