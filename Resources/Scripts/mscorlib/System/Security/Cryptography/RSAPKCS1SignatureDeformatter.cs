using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		private RSA rsa;

		private string hashName;

		public RSAPKCS1SignatureDeformatter()
		{
		}

		public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		{
		}

		public override void SetHashAlgorithm(string strName)
		{
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return false;
		}
	}
}
