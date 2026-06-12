using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class HMACSHA384 : HMAC
	{
		private bool m_useLegacyBlockSize;

		private int BlockSize => 0;

		public bool ProduceLegacyHmacValues
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public HMACSHA384()
		{
		}

		public HMACSHA384(byte[] key)
		{
		}
	}
}
