using System;
using System.Security.Cryptography;
using Photon.SocketServer.Numeric;

namespace Photon.SocketServer.Security
{
	internal class DiffieHellmanCryptoProvider : ICryptoProvider, IDisposable
	{
		private static readonly BigInteger primeRoot;

		private readonly BigInteger prime;

		private readonly BigInteger secret;

		private readonly BigInteger publicKey;

		private Rijndael crypto;

		private byte[] sharedKey;

		public byte[] PublicKey => null;

		public DiffieHellmanCryptoProvider()
		{
		}

		public DiffieHellmanCryptoProvider(byte[] sharedSecretHash)
		{
		}

		public void DeriveSharedKey(byte[] otherPartyPublicKey)
		{
		}

		public byte[] Encrypt(byte[] data, int offset, int count)
		{
			return null;
		}

		public byte[] Decrypt(byte[] data, int offset, int count)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		private BigInteger CalculatePublicKey()
		{
			return null;
		}

		private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey)
		{
			return null;
		}

		private BigInteger GenerateRandomSecret(int secretLength)
		{
			return null;
		}
	}
}
