using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class SHA384Managed : SHA384
	{
		private byte[] _buffer;

		private ulong _count;

		private ulong[] _stateSHA384;

		private ulong[] _W;

		private static readonly ulong[] _K;

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

		private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
		{
		}

		private static ulong RotateRight(ulong x, int n)
		{
			return 0uL;
		}

		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return 0uL;
		}

		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return 0uL;
		}

		private static ulong Sigma_0(ulong x)
		{
			return 0uL;
		}

		private static ulong Sigma_1(ulong x)
		{
			return 0uL;
		}

		private static ulong sigma_0(ulong x)
		{
			return 0uL;
		}

		private static ulong sigma_1(ulong x)
		{
			return 0uL;
		}

		private unsafe static void SHA384Expand(ulong* x)
		{
		}
	}
}
