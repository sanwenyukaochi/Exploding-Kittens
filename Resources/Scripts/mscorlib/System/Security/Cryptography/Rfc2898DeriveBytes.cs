namespace System.Security.Cryptography
{
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		private const int MinimumSaltSize = 8;

		private readonly byte[] _password;

		private byte[] _salt;

		private uint _iterations;

		private HMAC _hmac;

		private int _blockSize;

		private byte[] _buffer;

		private uint _block;

		private int _startIndex;

		private int _endIndex;

		public HashAlgorithmName HashAlgorithm { get; }

		public int IterationCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte[] Salt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
		{
		}

		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		public Rfc2898DeriveBytes(string password, byte[] salt)
		{
		}

		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
		{
		}

		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		public Rfc2898DeriveBytes(string password, int saltSize)
		{
		}

		public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
		{
		}

		public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override byte[] GetBytes(int cb)
		{
			return null;
		}

		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			return null;
		}

		public override void Reset()
		{
		}

		private HMAC OpenHmac()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private byte[] Func()
		{
			return null;
		}
	}
}
