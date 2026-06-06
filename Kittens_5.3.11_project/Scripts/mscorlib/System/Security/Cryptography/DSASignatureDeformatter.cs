using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		private DSA _dsaKey;

		private string _oid;

		public DSASignatureDeformatter()
		{
		}

		public DSASignatureDeformatter(AsymmetricAlgorithm key)
		{
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		public override void SetHashAlgorithm(string strName)
		{
		}

		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return false;
		}
	}
}
