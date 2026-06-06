using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class SignatureDescription
	{
		private string _strKey;

		private string _strDigest;

		private string _strFormatter;

		private string _strDeformatter;

		public string KeyAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DigestAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FormatterAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DeformatterAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SignatureDescription()
		{
		}

		public SignatureDescription(SecurityElement el)
		{
		}

		public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		public virtual HashAlgorithm CreateDigest()
		{
			return null;
		}
	}
}
