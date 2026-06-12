namespace ExitGames.Client.Photon.EncryptorManaged
{
	public class Decryptor : CryptoBase
	{
		private readonly byte[] IV;

		private readonly byte[] readBuffer;

		public byte[] DecryptBufferWithIV(byte[] data, int offset, int len, out int outLen)
		{
			outLen = default(int);
			return null;
		}

		public bool CheckHMAC(byte[] data, int len)
		{
			return false;
		}
	}
}
