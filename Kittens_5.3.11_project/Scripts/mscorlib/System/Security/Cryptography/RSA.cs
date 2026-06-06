using System.IO;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class RSA : AsymmetricAlgorithm
	{
		public override string KeyExchangeAlgorithm => null;

		public override string SignatureAlgorithm => null;

		public new static RSA Create()
		{
			return null;
		}

		public new static RSA Create(string algName)
		{
			return null;
		}

		public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		private static Exception DerivedClassMustOverride()
		{
			return null;
		}

		internal static Exception HashAlgorithmNameNullOrEmpty()
		{
			return null;
		}

		public virtual byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		public virtual byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		public override void FromXmlString(string xmlString)
		{
		}

		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		public abstract RSAParameters ExportParameters(bool includePrivateParameters);

		public abstract void ImportParameters(RSAParameters parameters);

		public static RSA Create(int keySizeInBits)
		{
			return null;
		}

		public static RSA Create(RSAParameters parameters)
		{
			return null;
		}

		public virtual bool TryDecrypt(ReadOnlySpan<byte> data, Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryEncrypt(ReadOnlySpan<byte> data, Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		protected virtual bool TryHashData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TrySignHash(ReadOnlySpan<byte> hash, Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TrySignData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool VerifyData(ReadOnlySpan<byte> data, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		public virtual bool VerifyHash(ReadOnlySpan<byte> hash, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		public virtual byte[] ExportRSAPrivateKey()
		{
			return null;
		}

		public virtual byte[] ExportRSAPublicKey()
		{
			return null;
		}

		public virtual void ImportRSAPrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual void ImportRSAPublicKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual bool TryExportRSAPrivateKey(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryExportRSAPublicKey(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}
	}
}
