using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class PasswordDeriveBytes : DeriveBytes
	{
		private int _extraCount;

		private int _prefix;

		private int _iterations;

		private byte[] _baseValue;

		private byte[] _extra;

		private byte[] _salt;

		private string _hashName;

		private byte[] _password;

		private HashAlgorithm _hash;

		public string HashName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt)
		{
		}

		public PasswordDeriveBytes(byte[] password, byte[] salt)
		{
		}

		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations)
		{
		}

		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations)
		{
		}

		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams)
		{
		}

		public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams)
		{
		}

		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams)
		{
		}

		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
		{
		}

		[Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
		public override byte[] GetBytes(int cb)
		{
			return null;
		}

		public override void Reset()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			return null;
		}

		private byte[] ComputeBaseValue()
		{
			return null;
		}

		private byte[] ComputeBytes(int cb)
		{
			return null;
		}

		private void HashPrefix(CryptoStream cs)
		{
		}
	}
}
