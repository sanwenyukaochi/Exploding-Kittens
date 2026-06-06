using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class PKCS1MaskGenerationMethod : MaskGenerationMethod
	{
		private string HashNameValue;

		public string HashName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn)
		{
			return null;
		}
	}
}
