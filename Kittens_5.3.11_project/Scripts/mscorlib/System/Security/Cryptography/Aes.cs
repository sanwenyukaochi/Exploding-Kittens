using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public abstract class Aes : SymmetricAlgorithm
	{
		private static KeySizes[] s_legalBlockSizes;

		private static KeySizes[] s_legalKeySizes;

		public new static Aes Create()
		{
			return null;
		}

		public new static Aes Create(string algorithmName)
		{
			return null;
		}
	}
}
