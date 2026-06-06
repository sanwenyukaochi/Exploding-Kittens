namespace System.Security.Cryptography
{
	public readonly struct HashAlgorithmName : IEquatable<HashAlgorithmName>
	{
		private readonly string _name;

		public static HashAlgorithmName MD5 => default(HashAlgorithmName);

		public static HashAlgorithmName SHA1 => default(HashAlgorithmName);

		public static HashAlgorithmName SHA256 => default(HashAlgorithmName);

		public static HashAlgorithmName SHA384 => default(HashAlgorithmName);

		public static HashAlgorithmName SHA512 => default(HashAlgorithmName);

		public string Name => null;

		public HashAlgorithmName(string name)
		{
			_name = null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(HashAlgorithmName other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
		{
			return false;
		}

		public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
		{
			return false;
		}
	}
}
