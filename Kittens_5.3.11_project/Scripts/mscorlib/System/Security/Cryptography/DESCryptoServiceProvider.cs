using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class DESCryptoServiceProvider : DES
	{
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
