using System.IO;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
	{
		private static CspProviderFlags s_UseMachineKeyStore;

		private const int PROV_RSA_FULL = 1;

		private const int AT_KEYEXCHANGE = 1;

		private const int AT_SIGNATURE = 2;

		private KeyPairPersistence store;

		private bool persistKey;

		private bool persisted;

		private bool privateKeyExportable;

		private bool m_disposed;

		private RSAManaged rsa;

		public override string SignatureAlgorithm => null;

		public static bool UseMachineKeyStore
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string KeyExchangeAlgorithm => null;

		public override int KeySize => 0;

		public bool PersistKeyInCsp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[ComVisible(false)]
		public bool PublicOnly => false;

		[ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo => null;

		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
		{
			return 0;
		}

		public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		private static Exception PaddingModeNotSupported()
		{
			return null;
		}

		public RSACryptoServiceProvider()
		{
		}

		public RSACryptoServiceProvider(CspParameters parameters)
		{
		}

		public RSACryptoServiceProvider(int dwKeySize)
		{
		}

		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
		}

		private void Common(int dwKeySize, bool parameters)
		{
		}

		private void Common(CspParameters p)
		{
		}

		~RSACryptoServiceProvider()
		{
		}

		public byte[] Decrypt(byte[] rgb, bool fOAEP)
		{
			return null;
		}

		public override byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		public byte[] Encrypt(byte[] rgb, bool fOAEP)
		{
			return null;
		}

		public override byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(RSAParameters);
		}

		public override void ImportParameters(RSAParameters parameters)
		{
		}

		private HashAlgorithm GetHash(object halg)
		{
			return null;
		}

		private HashAlgorithm GetHashFromString(string name)
		{
			return null;
		}

		public byte[] SignData(byte[] buffer, object halg)
		{
			return null;
		}

		public byte[] SignData(Stream inputStream, object halg)
		{
			return null;
		}

		public byte[] SignData(byte[] buffer, int offset, int count, object halg)
		{
			return null;
		}

		private string GetHashNameFromOID(string oid)
		{
			return null;
		}

		public byte[] SignHash(byte[] rgbHash, string str)
		{
			return null;
		}

		private byte[] SignHash(byte[] rgbHash, int calgHash)
		{
			return null;
		}

		private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash)
		{
			return null;
		}

		public bool VerifyData(byte[] buffer, object halg, byte[] signature)
		{
			return false;
		}

		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			return false;
		}

		private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
		{
			return false;
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void OnKeyGenerated(object sender, EventArgs e)
		{
		}

		[ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			return null;
		}

		[ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
		}
	}
}
