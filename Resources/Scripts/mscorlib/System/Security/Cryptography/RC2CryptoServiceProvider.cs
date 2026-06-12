using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class RC2CryptoServiceProvider : RC2
	{
		private bool m_use40bitSalt;

		private static KeySizes[] s_legalKeySizes;

		public override int EffectiveKeySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[ComVisible(false)]
		public bool UseSalt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		public override void GenerateKey()
		{
		}

		public override void GenerateIV()
		{
		}
	}
}
