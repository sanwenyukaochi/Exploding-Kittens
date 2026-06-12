using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class AsymmetricSignatureFormatter
	{
		public abstract void SetKey(AsymmetricAlgorithm key);

		public abstract void SetHashAlgorithm(string strName);

		public virtual byte[] CreateSignature(HashAlgorithm hash)
		{
			return null;
		}

		public abstract byte[] CreateSignature(byte[] rgbHash);
	}
}
