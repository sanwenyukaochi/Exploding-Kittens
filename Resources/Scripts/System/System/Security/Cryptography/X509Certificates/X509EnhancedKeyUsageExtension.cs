namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		private OidCollection _enhKeyUsage;

		private AsnDecodeStatus _status;

		public X509EnhancedKeyUsageExtension()
		{
		}

		public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
		{
		}

		public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
		{
		}

		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		internal AsnDecodeStatus Decode(byte[] extension)
		{
			return default(AsnDecodeStatus);
		}

		internal byte[] Encode()
		{
			return null;
		}

		internal override string ToString(bool multiLine)
		{
			return null;
		}
	}
}
