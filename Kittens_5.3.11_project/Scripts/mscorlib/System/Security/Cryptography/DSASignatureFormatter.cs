using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		private DSA _dsaKey;

		private string _oid;

		public DSASignatureFormatter()
		{
		}

		public DSASignatureFormatter(AsymmetricAlgorithm key)
		{
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		public override void SetHashAlgorithm(string strName)
		{
		}

		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}
	}
}
