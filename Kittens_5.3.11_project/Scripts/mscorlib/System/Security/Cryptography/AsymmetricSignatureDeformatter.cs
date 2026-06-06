using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class AsymmetricSignatureDeformatter
	{
		public abstract void SetKey(AsymmetricAlgorithm key);

		public abstract void SetHashAlgorithm(string strName);

		public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature)
		{
			return false;
		}

		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
	}
}
