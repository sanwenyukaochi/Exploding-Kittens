using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class MD5 : HashAlgorithm
	{
		public new static MD5 Create()
		{
			return null;
		}

		public new static MD5 Create(string algName)
		{
			return null;
		}
	}
}
