using System.IO;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
	{
		private const int PROV_DSS_DH = 13;

		private KeyPairPersistence store;

		private bool persistKey;

		private bool persisted;

		private bool privateKeyExportable;

		private bool m_disposed;

		private DSAManaged dsa;

		private static bool useMachineKeyStore;

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

		[MonoTODO("call into KeyPairPersistence to get details")]
		[ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo => null;

		public DSACryptoServiceProvider()
		{
		}

		public DSACryptoServiceProvider(CspParameters parameters)
		{
		}

		public DSACryptoServiceProvider(int dwKeySize)
		{
		}

		public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
		}

		private void Common(int dwKeySize, bool parameters)
		{
		}

		private void Common(CspParameters parameters)
		{
		}

		~DSACryptoServiceProvider()
		{
		}

		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(DSAParameters);
		}

		public override void ImportParameters(DSAParameters parameters)
		{
		}

		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		public byte[] SignData(byte[] buffer)
		{
			return null;
		}

		public byte[] SignData(byte[] buffer, int offset, int count)
		{
			return null;
		}

		public byte[] SignData(Stream inputStream)
		{
			return null;
		}

		public byte[] SignHash(byte[] rgbHash, string str)
		{
			return null;
		}

		public bool VerifyData(byte[] rgbData, byte[] rgbSignature)
		{
			return false;
		}

		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			return false;
		}

		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return false;
		}

		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
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
