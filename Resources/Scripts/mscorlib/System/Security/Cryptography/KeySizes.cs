using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class KeySizes
	{
		private int m_minSize;

		private int m_maxSize;

		private int m_skipSize;

		public int MinSize => 0;

		public int MaxSize => 0;

		public int SkipSize => 0;

		public KeySizes(int minSize, int maxSize, int skipSize)
		{
		}

		internal bool IsLegal(int keySize)
		{
			return false;
		}

		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
			return false;
		}
	}
}
