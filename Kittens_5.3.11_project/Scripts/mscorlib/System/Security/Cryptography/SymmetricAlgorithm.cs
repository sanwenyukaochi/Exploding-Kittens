using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public abstract class SymmetricAlgorithm : IDisposable
	{
		protected int BlockSizeValue;

		protected int FeedbackSizeValue;

		protected byte[] IVValue;

		protected byte[] KeyValue;

		protected KeySizes[] LegalBlockSizesValue;

		protected KeySizes[] LegalKeySizesValue;

		protected int KeySizeValue;

		protected CipherMode ModeValue;

		protected PaddingMode PaddingValue;

		public virtual int BlockSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int FeedbackSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual byte[] IV
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual byte[] Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual KeySizes[] LegalBlockSizes => null;

		public virtual KeySizes[] LegalKeySizes => null;

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

		public virtual CipherMode Mode
		{
			get
			{
				return default(CipherMode);
			}
			set
			{
			}
		}

		public virtual PaddingMode Padding
		{
			get
			{
				return default(PaddingMode);
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public bool ValidKeySize(int bitLength)
		{
			return false;
		}

		public static SymmetricAlgorithm Create()
		{
			return null;
		}

		public static SymmetricAlgorithm Create(string algName)
		{
			return null;
		}

		public virtual ICryptoTransform CreateEncryptor()
		{
			return null;
		}

		public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

		public virtual ICryptoTransform CreateDecryptor()
		{
			return null;
		}

		public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

		public abstract void GenerateKey();

		public abstract void GenerateIV();
	}
}
