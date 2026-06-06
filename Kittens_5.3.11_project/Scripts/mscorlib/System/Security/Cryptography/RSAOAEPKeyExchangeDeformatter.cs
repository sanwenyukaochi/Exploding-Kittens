using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		private RSA _rsaKey;

		private bool? _rsaOverridesDecrypt;

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

		public RSAOAEPKeyExchangeDeformatter()
		{
		}

		public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
		}

		public override byte[] DecryptKeyExchange(byte[] rgbData)
		{
			return null;
		}

		public override void SetKey(AsymmetricAlgorithm key)
		{
		}
	}
}
