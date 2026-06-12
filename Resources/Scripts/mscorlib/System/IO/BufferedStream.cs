using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	public sealed class BufferedStream : Stream
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFlushAsyncInternal_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public BufferedStream _003C_003E4__this;

			public CancellationToken cancellationToken;

			private SemaphoreSlim _003Csem_003E5__2;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFlushWriteAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public BufferedStream _003C_003E4__this;

			public CancellationToken cancellationToken;

			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadFromUnderlyingStreamAsync_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncValueTaskMethodBuilder<int> _003C_003Et__builder;

			public Task semaphoreLockTask;

			public BufferedStream _003C_003E4__this;

			public Memory<byte> buffer;

			public int bytesAlreadySatisfied;

			public CancellationToken cancellationToken;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private int _003C_003E7__wrap1;

			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteToUnderlyingStreamAsync_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Task semaphoreLockTask;

			public BufferedStream _003C_003E4__this;

			public ReadOnlyMemory<byte> buffer;

			public CancellationToken cancellationToken;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private Stream _stream;

		private byte[] _buffer;

		private readonly int _bufferSize;

		private int _readPos;

		private int _readLen;

		private int _writePos;

		private Task<int> _lastSyncCompletedReadTask;

		private SemaphoreSlim _asyncActiveSemaphore;

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

		internal SemaphoreSlim LazyEnsureAsyncActiveSemaphoreInitialized()
		{
			return null;
		}

		public BufferedStream(Stream stream)
		{
		}

		public BufferedStream(Stream stream, int bufferSize)
		{
		}

		private void EnsureNotClosed()
		{
		}

		private void EnsureCanSeek()
		{
		}

		private void EnsureCanRead()
		{
		}

		private void EnsureCanWrite()
		{
		}

		private void EnsureShadowBufferAllocated()
		{
		}

		private void EnsureBufferAllocated()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFlushAsyncInternal_003Ed__38))]
		private Task FlushAsyncInternal(CancellationToken cancellationToken)
		{
			return null;
		}

		private void FlushRead()
		{
		}

		private void ClearReadBufferBeforeWrite()
		{
		}

		private void FlushWrite()
		{
		}

		[AsyncStateMachine(typeof(_003CFlushWriteAsync_003Ed__42))]
		private Task FlushWriteAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private int ReadFromBuffer(byte[] array, int offset, int count)
		{
			return 0;
		}

		private int ReadFromBuffer(Span<byte> destination)
		{
			return 0;
		}

		private int ReadFromBuffer(byte[] array, int offset, int count, out Exception error)
		{
			error = null;
			return 0;
		}

		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		public override int Read(Span<byte> destination)
		{
			return 0;
		}

		private Task<int> LastSyncCompletedReadTask(int val)
		{
			return null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask<int>);
		}

		[AsyncStateMachine(typeof(_003CReadFromUnderlyingStreamAsync_003Ed__51))]
		private ValueTask<int> ReadFromUnderlyingStreamAsync(Memory<byte> buffer, CancellationToken cancellationToken, int bytesAlreadySatisfied, Task semaphoreLockTask)
		{
			return default(ValueTask<int>);
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override int ReadByte()
		{
			return 0;
		}

		private int ReadByteSlow()
		{
			return 0;
		}

		private void WriteToBuffer(byte[] array, ref int offset, ref int count)
		{
		}

		private int WriteToBuffer(ReadOnlySpan<byte> buffer)
		{
			return 0;
		}

		public override void Write(byte[] array, int offset, int count)
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

		[AsyncStateMachine(typeof(_003CWriteToUnderlyingStreamAsync_003Ed__63))]
		private Task WriteToUnderlyingStreamAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken, Task semaphoreLockTask)
		{
			return null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override void WriteByte(byte value)
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
