using System;
using System.Security.Cryptography;

namespace ExitGames.Client.Photon.EncryptorManaged
{
	public class CryptoBase : IDisposable
	{
		public const int BLOCK_SIZE = 16;

		public const int IV_SIZE = 16;

		public const int HMAC_SIZE = 32;

		protected Aes encryptor;

		protected HMACSHA256 hmacsha256;

		~CryptoBase()
		{
		}

		public void Init(byte[] encryptionSecret, byte[] hmacSecret)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool dispose)
		{
		}
	}
}
