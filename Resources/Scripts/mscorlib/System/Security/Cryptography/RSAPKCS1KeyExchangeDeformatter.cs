using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		private RSA _rsaKey;

		private bool? _rsaOverridesDecrypt;

		private RandomNumberGenerator RngValue;

		public RandomNumberGenerator RNG
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string Parameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool OverridesDecrypt => false;

		public RSAPKCS1KeyExchangeDeformatter()
		{
		}

		public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
		}

		public override byte[] DecryptKeyExchange(byte[] rgbIn)
		{
			return null;
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}
	}
}
