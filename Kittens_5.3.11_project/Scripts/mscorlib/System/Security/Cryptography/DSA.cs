using System.IO;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class DSA : AsymmetricAlgorithm
	{
		public new static DSA Create()
		{
			return null;
		}

		public new static DSA Create(string algName)
		{
			return null;
		}

		public abstract byte[] CreateSignature(byte[] rgbHash);

		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			return false;
		}

		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			return false;
		}

		public virtual bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			return false;
		}

		public override void FromXmlString(string xmlString)
		{
		}

		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		public abstract DSAParameters ExportParameters(bool includePrivateParameters);

		public abstract void ImportParameters(DSAParameters parameters);

		private static Exception DerivedClassMustOverride()
		{
			return null;
		}

		internal static Exception HashAlgorithmNameNullOrEmpty()
		{
			return null;
		}

		public static DSA Create(int keySizeInBits)
		{
			return null;
		}

		public static DSA Create(DSAParameters parameters)
		{
			return null;
		}

		public virtual bool TryCreateSignature(ReadOnlySpan<byte> hash, Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		protected virtual bool TryHashData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TrySignData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool VerifyData(ReadOnlySpan<byte> data, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm)
		{
			return false;
		}

		public virtual bool VerifySignature(ReadOnlySpan<byte> hash, ReadOnlySpan<byte> signature)
		{
			return false;
		}
	}
}
