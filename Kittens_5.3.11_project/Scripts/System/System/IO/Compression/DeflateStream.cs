using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression
{
	public class DeflateStream : Stream
	{
		private delegate int ReadMethod(byte[] array, int offset, int count);

		private delegate void WriteMethod(byte[] array, int offset, int count);

		private Stream base_stream;

		private CompressionMode mode;

		private bool leaveOpen;

		private bool disposed;

		private DeflateStreamNative native;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

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

		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits)
		{
		}

		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
		{
		}

		~DeflateStream()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private int ReadInternal(byte[] array, int offset, int count)
		{
			return 0;
		}

		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		internal int ReadCore(Span<byte> destination)
		{
			return 0;
		}

		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		private void WriteInternal(byte[] array, int offset, int count)
		{
		}

		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		internal void WriteCore(ReadOnlySpan<byte> source)
		{
		}

		public override void Write(byte[] array, int offset, int count)
		{
		}

		public override void Flush()
		{
		}

		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}
	}
}
