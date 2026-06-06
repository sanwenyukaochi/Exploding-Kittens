using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	[Serializable]
	public class MemoryStream : Stream
	{
		private byte[] _buffer;

		private int _origin;

		private int _position;

		private int _length;

		private int _capacity;

		private bool _expandable;

		private bool _writable;

		private bool _exposable;

		private bool _isOpen;

		[NonSerialized]
		private Task<int> _lastReadTask;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public virtual int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public MemoryStream()
		{
		}

		public MemoryStream(int capacity)
		{
		}

		public MemoryStream(byte[] buffer)
		{
		}

		public MemoryStream(byte[] buffer, bool writable)
		{
		}

		public MemoryStream(byte[] buffer, int index, int count)
		{
		}

		public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
		}

		private void EnsureNotClosed()
		{
		}

		private void EnsureWriteable()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private bool EnsureCapacity(int value)
		{
			return false;
		}

		public override void Flush()
		{
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public virtual byte[] GetBuffer()
		{
			return null;
		}

		internal byte[] InternalGetBuffer()
		{
			return null;
		}

		internal int InternalGetPosition()
		{
			return 0;
		}

		internal int InternalReadInt32()
		{
			return 0;
		}

		internal int InternalEmulateRead(int count)
		{
			return 0;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override int Read(Span<byte> buffer)
		{
			return 0;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask<int>);
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin loc)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public virtual byte[] ToArray()
		{
			return null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Write(ReadOnlySpan<byte> buffer)
		{
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask);
		}

		public override void WriteByte(byte value)
		{
		}
	}
}
