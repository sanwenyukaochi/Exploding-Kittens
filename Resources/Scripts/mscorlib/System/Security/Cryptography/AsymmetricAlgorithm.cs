using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class AsymmetricAlgorithm : IDisposable
	{
		protected int KeySizeValue;

		protected KeySizes[] LegalKeySizesValue;

		public virtual int KeySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual KeySizes[] LegalKeySizes => null;

		public virtual string SignatureAlgorithm => null;

		public virtual string KeyExchangeAlgorithm => null;

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public static AsymmetricAlgorithm Create()
		{
			return null;
		}

		public static AsymmetricAlgorithm Create(string algName)
		{
			return null;
		}

		public virtual void FromXmlString(string xmlString)
		{
		}

		public virtual string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		public virtual byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters)
		{
			return null;
		}

		public virtual byte[] ExportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, PbeParameters pbeParameters)
		{
			return null;
		}

		public virtual byte[] ExportPkcs8PrivateKey()
		{
			return null;
		}

		public virtual byte[] ExportSubjectPublicKeyInfo()
		{
			return null;
		}

		public virtual void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual void ImportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual void ImportPkcs8PrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual void ImportSubjectPublicKeyInfo(ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters, Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryExportEncryptedPkcs8PrivateKey(ReadOnlySpan<char> password, PbeParameters pbeParameters, Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryExportPkcs8PrivateKey(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryExportSubjectPublicKeyInfo(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}
	}
}
