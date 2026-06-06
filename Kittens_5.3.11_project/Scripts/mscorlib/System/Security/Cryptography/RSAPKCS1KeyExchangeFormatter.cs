using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		private RandomNumberGenerator RngValue;

		private RSA _rsaKey;

		private bool? _rsaOverridesEncrypt;

		public override string Parameters => null;

		public RandomNumberGenerator Rng
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool OverridesEncrypt => false;

		public RSAPKCS1KeyExchangeFormatter()
		{
		}

		public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
		{
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			return null;
		}

		public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
		{
			return null;
		}
	}
}
