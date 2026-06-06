using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Net.Sockets
{
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		private bool disposed;

		internal int in_progress;

		private EndPoint remote_ep;

		private Socket current_socket;

		internal SocketAsyncResult socket_async_result;

		[CompilerGenerated]
		private SocketAsyncOperation _003CLastOperation_003Ek__BackingField;

		[CompilerGenerated]
		private SocketFlags _003CSocketFlags_003Ek__BackingField;

		[CompilerGenerated]
		private EventHandler<SocketAsyncEventArgs> Completed;

		private Memory<byte> _buffer;

		private int _offset;

		private int _count;

		private bool _bufferIsExplicitArray;

		private IList<ArraySegment<byte>> _bufferList;

		public Socket AcceptSocket { get; set; }

		public int BytesTransferred { get; private set; }

		private SocketAsyncOperation LastOperation
		{
			[CompilerGenerated]
			set
			{
				_003CLastOperation_003Ek__BackingField = value;
			}
		}

		public EndPoint RemoteEndPoint
		{
			set
			{
			}
		}

		public SocketError SocketError { get; set; }

		public SocketFlags SocketFlags
		{
			[CompilerGenerated]
			set
			{
				_003CSocketFlags_003Ek__BackingField = value;
			}
		}

		public object UserToken { get; set; }

		internal Socket CurrentSocket => null;

		public Memory<byte> MemoryBuffer => default(Memory<byte>);

		public int Offset => 0;

		public int Count => 0;

		public IList<ArraySegment<byte>> BufferList => null;

		internal SocketAsyncEventArgs(bool flowExecutionContext)
		{
		}

		~SocketAsyncEventArgs()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		internal void SetBytesTransferred(int value)
		{
		}

		internal void SetCurrentSocket(Socket socket)
		{
		}

		internal void SetLastOperation(SocketAsyncOperation op)
		{
		}

		internal void Complete_internal()
		{
		}

		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
		}

		public void SetBuffer(Memory<byte> buffer)
		{
		}
	}
}
