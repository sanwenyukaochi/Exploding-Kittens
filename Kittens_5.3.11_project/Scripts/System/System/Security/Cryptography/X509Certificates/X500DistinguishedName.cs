namespace System.Security.Cryptography.X509Certificates
{
	[System.MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
	public sealed class X500DistinguishedName : AsnEncodedData
	{
		private string name;

		private byte[] canonEncoding;

		public string Name => null;

		public X500DistinguishedName(byte[] encodedDistinguishedName)
		{
		}

		public string Decode(X500DistinguishedNameFlags flag)
		{
			return null;
		}

		public override string Format(bool multiLine)
		{
			return null;
		}

		private static string GetSeparator(X500DistinguishedNameFlags flag)
		{
			return null;
		}

		private void DecodeRawData()
		{
		}

		private static string Canonize(string s)
		{
			return null;
		}

		internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
		{
			return false;
		}
	}
}
