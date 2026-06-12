using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class Rijndael : SymmetricAlgorithm
	{
		private static KeySizes[] s_legalBlockSizes;

		private static KeySizes[] s_legalKeySizes;

		public new static Rijndael Create()
		{
			return null;
		}

		public new static Rijndael Create(string algName)
		{
			return null;
		}
	}
}
