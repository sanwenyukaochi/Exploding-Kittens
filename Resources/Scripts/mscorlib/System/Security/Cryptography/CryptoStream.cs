using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
	public class CryptoStream : Stream, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadAsyncInternal_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			public CryptoStream _003C_003E4__this;

			public byte[] buffer;

			public int offset;

			public int count;

			public CancellationToken cancellationToken;

			private SemaphoreSlim _003Csemaphore_003E5__2;

			private ForceAsyncAwaiter _003C_003Eu__1;

			private TaskAwaiter<int> _003C_003Eu__2;

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
		private struct _003CReadAsyncCore_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			public int count;

			public int offset;

			public CryptoStream _003C_003E4__this;

			public byte[] buffer;

			public bool useAsync;

			public CancellationToken cancellationToken;

			private int _003CbytesToDeliver_003E5__2;

			private int _003CcurrentOutputIndex_003E5__3;

			private int _003CnumWholeBlocksInBytes_003E5__4;

			private byte[] _003CtempInputBuffer_003E5__5;

			private byte[] _003CtempOutputBuffer_003E5__6;

			private ValueTaskAwaiter<int> _003C_003Eu__1;

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
		private struct _003CWriteAsyncInternal_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CryptoStream _003C_003E4__this;

			public byte[] buffer;

			public int offset;

			public int count;

			public CancellationToken cancellationToken;

			private SemaphoreSlim _003Csemaphore_003E5__2;

			private ForceAsyncAwaiter _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CWriteAsyncCore_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public int count;

			public int offset;

			public CryptoStream _003C_003E4__this;

			public byte[] buffer;

			public bool useAsync;

			public CancellationToken cancellationToken;

			private int _003CbytesToWrite_003E5__2;

			private int _003CcurrentInputIndex_003E5__3;

			private int _003CnumOutputBytes_003E5__4;

			private ValueTaskAwaiter _003C_003Eu__1;

			private int _003CnumWholeBlocksInBytes_003E5__5;

			private byte[] _003CtempOutputBuffer_003E5__6;

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

		private readonly Stream _stream;

		private readonly ICryptoTransform _transform;

		private readonly CryptoStreamMode _transformMode;

		private byte[] _inputBuffer;

		private int _inputBufferIndex;

		private int _inputBlockSize;

		private byte[] _outputBuffer;

		private int _outputBufferIndex;

		private int _outputBlockSize;

		private bool _canRead;

		private bool _canWrite;

		private bool _finalBlockTransformed;

		private SemaphoreSlim _lazyAsyncActiveSemaphore;

		private readonly bool _leaveOpen;

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

		public bool HasFlushedFinalBlock => false;

		private SemaphoreSlim AsyncActiveSemaphore => null;

		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
		{
		}

		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
		{
		}

		public void FlushFinalBlock()
		{
		}

		public override void Flush()
		{
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CReadAsyncInternal_003Ed__37))]
		private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override void WriteByte(byte value)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		private void CheckReadArguments(byte[] buffer, int offset, int count)
		{
		}

		[AsyncStateMachine(typeof(_003CReadAsyncCore_003Ed__42))]
		private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			return null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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

		[AsyncStateMachine(typeof(_003CWriteAsyncInternal_003Ed__46))]
		private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		private void CheckWriteArguments(byte[] buffer, int offset, int count)
		{
		}

		[AsyncStateMachine(typeof(_003CWriteAsyncCore_003Ed__49))]
		private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			return null;
		}

		public void Clear()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void InitializeBuffer()
		{
		}
	}
}
