namespace System.Security.Cryptography
{
	public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding>
	{
		private static readonly RSASignaturePadding s_pkcs1;

		private static readonly RSASignaturePadding s_pss;

		private readonly RSASignaturePaddingMode _mode;

		public static RSASignaturePadding Pkcs1 => null;

		public static RSASignaturePadding Pss => null;

		public RSASignaturePaddingMode Mode => default(RSASignaturePaddingMode);

		private RSASignaturePadding(RSASignaturePaddingMode mode)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(RSASignaturePadding other)
		{
			return false;
		}

		public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
		{
			return false;
		}

		public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal RSASignaturePadding()
		{
		}
	}
}
