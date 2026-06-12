using System.IO;

namespace ExitGames.Client.Photon
{
	public class StreamBuffer
	{
		private const int DefaultInitialSize = 0;

		private int pos;

		private int len;

		private byte[] buf;

		public int Length => 0;

		public int Position
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public StreamBuffer(int size = 0)
		{
		}

		public StreamBuffer(byte[] buf)
		{
		}

		public byte[] ToArray()
		{
			return null;
		}

		public byte[] ToArrayFromPos()
		{
			return null;
		}

		public void Compact()
		{
		}

		public byte[] GetBuffer()
		{
			return null;
		}

		public byte[] GetBufferAndAdvance(int length, out int offset)
		{
			offset = default(int);
			return null;
		}

		public long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public void SetLength(long value)
		{
		}

		public void SetCapacityMinimum(int neededSize)
		{
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public void Write(byte[] buffer, int srcOffset, int count)
		{
		}

		public int ReadByte()
		{
			return 0;
		}

		public void WriteByte(byte value)
		{
		}

		public void WriteBytes(byte v0, byte v1)
		{
		}

		private bool CheckSize(int size)
		{
			return false;
		}
	}
}
