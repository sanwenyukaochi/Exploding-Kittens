using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	public class NetworkStream : Stream
	{
		private readonly Socket _streamSocket;

		private readonly bool _ownsSocket;

		private bool _readable;

		private bool _writeable;

		private int _closeTimeout;

		private bool _cleanedUp;

		private int _currentReadTimeout;

		private int _currentWriteTimeout;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override bool CanTimeout => false;

		public override int ReadTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int WriteTimeout
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

		internal Socket InternalSocket => null;

		public NetworkStream(Socket socket)
		{
		}

		public NetworkStream(Socket socket, bool ownsSocket)
		{
		}

		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		public override int Read(Span<byte> destination)
		{
			return 0;
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int size)
		{
		}

		public override void Write(ReadOnlySpan<byte> source)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public void Close(int timeout)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		~NetworkStream()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		public override void Flush()
		{
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override void SetLength(long value)
		{
		}

		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
		}
	}
}
