using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class DES : SymmetricAlgorithm
	{
		private static KeySizes[] s_legalBlockSizes;

		private static KeySizes[] s_legalKeySizes;

		public override byte[] Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new static DES Create()
		{
			return null;
		}

		public new static DES Create(string algName)
		{
			return null;
		}

		public static bool IsWeakKey(byte[] rgbKey)
		{
			return false;
		}

		public static bool IsSemiWeakKey(byte[] rgbKey)
		{
			return false;
		}

		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return false;
		}

		private static ulong QuadWordFromBigEndian(byte[] block)
		{
			return 0uL;
		}
	}
}
