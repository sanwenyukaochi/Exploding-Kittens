using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
		private RSA rsa;

		private string hash;

		public RSAPKCS1SignatureFormatter()
		{
		}

		public RSAPKCS1SignatureFormatter(AsymmetricAlgorithm key)
		{
		}

		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		public override void SetHashAlgorithm(string strName)
		{
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}
	}
}
