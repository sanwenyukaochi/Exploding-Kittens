using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression
{
	public class GZipStream : Stream
	{
		private DeflateStream _deflateStream;

		public override bool CanRead => false;

		public override bool CanWrite => false;

		public override bool CanSeek => false;

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

		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		public override int Read(Span<byte> buffer)
		{
			return 0;
		}

		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override void Write(byte[] array, int offset, int count)
		{
		}

		public override void Write(ReadOnlySpan<byte> buffer)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask<int>);
		}

		public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask);
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private void CheckDeflateStream()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowStreamClosedException()
		{
		}
	}
}
