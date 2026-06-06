namespace System.Security.Cryptography
{
	public sealed class RSAEncryptionPadding : IEquatable<RSAEncryptionPadding>
	{
		private static readonly RSAEncryptionPadding s_pkcs1;

		private static readonly RSAEncryptionPadding s_oaepSHA1;

		private static readonly RSAEncryptionPadding s_oaepSHA256;

		private static readonly RSAEncryptionPadding s_oaepSHA384;

		private static readonly RSAEncryptionPadding s_oaepSHA512;

		private RSAEncryptionPaddingMode _mode;

		private HashAlgorithmName _oaepHashAlgorithm;

		public static RSAEncryptionPadding Pkcs1 => null;

		public static RSAEncryptionPadding OaepSHA1 => null;

		public static RSAEncryptionPadding OaepSHA256 => null;

		public static RSAEncryptionPadding OaepSHA384 => null;

		public static RSAEncryptionPadding OaepSHA512 => null;

		public RSAEncryptionPaddingMode Mode => default(RSAEncryptionPaddingMode);

		public HashAlgorithmName OaepHashAlgorithm => default(HashAlgorithmName);

		private RSAEncryptionPadding(RSAEncryptionPaddingMode mode, HashAlgorithmName oaepHashAlgorithm)
		{
		}

		public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(RSAEncryptionPadding other)
		{
			return false;
		}

		public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			return false;
		}

		public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal RSAEncryptionPadding()
		{
		}
	}
}
