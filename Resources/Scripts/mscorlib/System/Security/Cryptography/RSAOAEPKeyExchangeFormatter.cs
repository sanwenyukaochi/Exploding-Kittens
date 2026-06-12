using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		private byte[] ParameterValue;

		private RSA _rsaKey;

		private bool? _rsaOverridesEncrypt;

		private RandomNumberGenerator RngValue;

		public byte[] Parameter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public RSAOAEPKeyExchangeFormatter()
		{
		}

		public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key)
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
