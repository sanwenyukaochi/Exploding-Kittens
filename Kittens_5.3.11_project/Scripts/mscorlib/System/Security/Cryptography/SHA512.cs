using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class SHA512 : HashAlgorithm
	{
		public new static SHA512 Create()
		{
			return null;
		}

		public new static SHA512 Create(string hashName)
		{
			return null;
		}
	}
}
