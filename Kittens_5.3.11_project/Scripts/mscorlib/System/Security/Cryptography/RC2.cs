using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class RC2 : SymmetricAlgorithm
	{
		protected int EffectiveKeySizeValue;

		private static KeySizes[] s_legalBlockSizes;

		private static KeySizes[] s_legalKeySizes;

		public virtual int EffectiveKeySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int KeySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public new static RC2 Create()
		{
			return null;
		}

		public new static RC2 Create(string AlgName)
		{
			return null;
		}
	}
}
