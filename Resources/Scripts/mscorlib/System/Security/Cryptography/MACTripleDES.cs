using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public class MACTripleDES : KeyedHashAlgorithm
	{
		private ICryptoTransform m_encryptor;

		private CryptoStream _cs;

		private TailStream _ts;

		private const int m_bitsPerByte = 8;

		private int m_bytesPerBlock;

		private TripleDES des;

		[ComVisible(false)]
		public PaddingMode Padding
		{
			get
			{
				return default(PaddingMode);
			}
			set
			{
			}
		}

		public MACTripleDES()
		{
		}

		public MACTripleDES(byte[] rgbKey)
		{
		}

		public MACTripleDES(string strTripleDES, byte[] rgbKey)
		{
		}

		public override void Initialize()
		{
		}

		protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
		{
		}

		protected override byte[] HashFinal()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
