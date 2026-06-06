using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class SHA256 : HashAlgorithm
	{
		public new static SHA256 Create()
		{
			return null;
		}

		public new static SHA256 Create(string hashName)
		{
			return null;
		}
	}
}
