using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class SHA1 : HashAlgorithm
	{
		public new static SHA1 Create()
		{
			return null;
		}

		public new static SHA1 Create(string hashName)
		{
			return null;
		}
	}
}
