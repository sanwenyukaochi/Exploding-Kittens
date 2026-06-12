using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class TripleDES : SymmetricAlgorithm
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

		public new static TripleDES Create()
		{
			return null;
		}

		public new static TripleDES Create(string str)
		{
			return null;
		}

		public static bool IsWeakKey(byte[] rgbKey)
		{
			return false;
		}

		private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count)
		{
			return false;
		}

		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return false;
		}
	}
}
