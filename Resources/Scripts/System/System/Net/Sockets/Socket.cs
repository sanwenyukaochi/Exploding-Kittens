using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Net.Sockets
{
	public class Socket : IDisposable
	{
		private sealed class CachedEventArgs
		{
			public TaskSocketAsyncEventArgs<Socket> TaskAccept;

			public Int32TaskSocketAsyncEventArgs TaskReceive;

			public Int32TaskSocketAsyncEventArgs TaskSend;

			public AwaitableSocketAsyncEventArgs ValueTaskReceive;

			public AwaitableSocketAsyncEventArgs ValueTaskSend;
		}

		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			internal AsyncTaskMethodBuilder<TResult> _builder;

			internal bool _accessed;

			internal TaskSocketAsyncEventArgs()
				: base(flowExecutionContext: false)
			{
			}

			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
			{
				responsibleForReturningToPool = default(bool);
				return default(AsyncTaskMethodBuilder<TResult>);
			}
		}

		private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs<int>
		{
			internal bool _wrapExceptionsInIOExceptions;
		}

		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
		{
			internal static readonly AwaitableSocketAsyncEventArgs Reserved;

			private static readonly Action<object> s_completedSentinel;

			private static readonly Action<object> s_availableSentinel;

			private Action<object> _continuation;

			private ExecutionContext _executionContext;

			private object _scheduler;

			private short _token;

			public bool WrapExceptionsInIOExceptions { get; set; }

			public AwaitableSocketAsyncEventArgs()
				: base(flowExecutionContext: false)
			{
			}

			public bool Reserve()
			{
				return false;
			}

			private void Release()
			{
			}

			protected override void OnCompleted(SocketAsyncEventArgs _)
			{
			}

			public ValueTask<int> ReceiveAsync(Socket socket)
			{
				return default(ValueTask<int>);
			}

			public ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				return default(ValueTask);
			}

			public ValueTaskSourceStatus GetStatus(short token)
			{
				return default(ValueTaskSourceStatus);
			}

			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
			}

			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
			{
			}

			public int GetResult(short token)
			{
				return 0;
			}

			void IValueTaskSource.GetResult(short token)
			{
			}

			private void ThrowIncorrectTokenException()
			{
			}

			private void ThrowMultipleContinuationsException()
			{
			}

			private void ThrowException(SocketError error)
			{
			}

			private Exception CreateException(SocketError error)
			{
				return null;
			}
		}

		private struct WSABUF
		{
			public int len;

			public IntPtr buf;
		}

		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler;

		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler;

		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler;

		private static readonly TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel;

		private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;

		private static readonly Task<int> s_zeroTask;

		private CachedEventArgs _cachedTaskEventArgs;

		private static object s_InternalSyncObject;

		internal static bool s_SupportsIPv4;

		internal static bool s_SupportsIPv6;

		internal static bool s_OSSupportsIPv6;

		internal static bool s_Initialized;

		private static bool s_LoggingEnabled;

		private bool is_closed;

		private bool is_listening;

		private int linger_timeout;

		private AddressFamily addressFamily;

		private SocketType socketType;

		private ProtocolType protocolType;

		internal SafeSocketHandle m_Handle;

		internal EndPoint seed_endpoint;

		internal SemaphoreSlim ReadSem;

		internal SemaphoreSlim WriteSem;

		internal bool is_blocking;

		internal bool is_bound;

		internal bool is_connected;

		private int m_IntCleanedUp;

		internal bool connect_in_progress;

		private static AsyncCallback AcceptAsyncCallback;

		private static IOAsyncCallback BeginAcceptCallback;

		private static IOAsyncCallback BeginAcceptReceiveCallback;

		private static AsyncCallback ConnectAsyncCallback;

		private static IOAsyncCallback BeginConnectCallback;

		private static AsyncCallback DisconnectAsyncCallback;

		private static IOAsyncCallback BeginDisconnectCallback;

		private static AsyncCallback ReceiveAsyncCallback;

		private static IOAsyncCallback BeginReceiveCallback;

		private static IOAsyncCallback BeginReceiveGenericCallback;

		private static AsyncCallback ReceiveFromAsyncCallback;

		private static IOAsyncCallback BeginReceiveFromCallback;

		private static AsyncCallback SendAsyncCallback;

		private static IOAsyncCallback BeginSendGenericCallback;

		private static AsyncCallback SendToAsyncCallback;

		public static bool OSSupportsIPv4 => false;

		public static bool OSSupportsIPv6 => false;

		public IntPtr Handle => (IntPtr)0;

		public AddressFamily AddressFamily => default(AddressFamily);

		public SocketType SocketType => default(SocketType);

		public ProtocolType ProtocolType => default(ProtocolType);

		public int ReceiveTimeout
		{
			set
			{
			}
		}

		public int SendTimeout
		{
			set
			{
			}
		}

		public bool DontFragment
		{
			set
			{
			}
		}

		public bool DualMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool IsDualMode => false;

		private static object InternalSyncObject => null;

		internal bool CleanedUp => false;

		public int Available => 0;

		public bool IsBound => false;

		public EndPoint LocalEndPoint => null;

		public bool Blocking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Connected => false;

		public bool NoDelay
		{
			set
			{
			}
		}

		public EndPoint RemoteEndPoint => null;

		internal static int FamilyHint => 0;

		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			return null;
		}

		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			return null;
		}

		private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs<Socket> saea)
		{
		}

		private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
		}

		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			return null;
		}

		private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
		}

		private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs<Socket> saea)
		{
		}

		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
		}

		internal bool CanTryAddressFamily(AddressFamily family)
		{
			return false;
		}

		public void Connect(IPAddress[] addresses, int port)
		{
		}

		public int Send(byte[] buffer)
		{
			return 0;
		}

		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return 0;
		}

		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return 0;
		}

		public int Receive(byte[] buffer, SocketFlags socketFlags)
		{
			return 0;
		}

		public int Receive(byte[] buffer)
		{
			return 0;
		}

		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return 0;
		}

		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return 0;
		}

		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return 0;
		}

		public void SetIPProtectionLevel(IPProtectionLevel level)
		{
		}

		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return null;
		}

		public int EndSend(IAsyncResult asyncResult)
		{
			return 0;
		}

		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return null;
		}

		public int EndReceive(IAsyncResult asyncResult)
		{
			return 0;
		}

		internal static void InitializeSockets()
		{
		}

		public void Dispose()
		{
		}

		~Socket()
		{
		}

		internal void InternalShutdown(SocketShutdown how)
		{
		}

		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
		}

		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		{
		}

		private void SocketDefaults()
		{
		}

		private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error)
		{
			error = default(int);
			return (IntPtr)0;
		}

		private static int Available_internal(SafeSocketHandle safeHandle, out int error)
		{
			error = default(int);
			return 0;
		}

		private static int Available_icall(IntPtr socket, out int error)
		{
			error = default(int);
			return 0;
		}

		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			error = default(int);
			return null;
		}

		private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error)
		{
			error = default(int);
			return null;
		}

		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			error = default(int);
		}

		internal static void Blocking_icall(IntPtr socket, bool block, out int error)
		{
			error = default(int);
		}

		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			error = default(int);
			return null;
		}

		private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error)
		{
			error = default(int);
			return null;
		}

		public bool Poll(int microSeconds, SelectMode mode)
		{
			return false;
		}

		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			error = default(int);
			return false;
		}

		private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error)
		{
			error = default(int);
			return false;
		}

		public Socket Accept()
		{
			return null;
		}

		internal void Accept(Socket acceptSocket)
		{
		}

		public IAsyncResult BeginAccept(AsyncCallback callback, object state)
		{
			return null;
		}

		public Socket EndAccept(IAsyncResult asyncResult)
		{
			return null;
		}

		public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			buffer = null;
			bytesTransferred = default(int);
			return null;
		}

		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			error = default(int);
			return null;
		}

		private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking)
		{
			error = default(int);
			return (IntPtr)0;
		}

		public void Bind(EndPoint localEP)
		{
		}

		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			error = default(int);
		}

		private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error)
		{
			error = default(int);
		}

		public void Listen(int backlog)
		{
		}

		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			error = default(int);
		}

		private static void Listen_icall(IntPtr sock, int backlog, out int error)
		{
			error = default(int);
		}

		public void Connect(IPAddress address, int port)
		{
		}

		public void Connect(string host, int port)
		{
		}

		public void Connect(EndPoint remoteEP)
		{
		}

		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			return null;
		}

		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			return null;
		}

		private static bool BeginMConnect(SocketAsyncResult sockares)
		{
			return false;
		}

		private static bool BeginSConnect(SocketAsyncResult sockares)
		{
			return false;
		}

		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			error = default(int);
		}

		private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking)
		{
			error = default(int);
		}

		public void Disconnect(bool reuseSocket)
		{
		}

		public void EndDisconnect(IAsyncResult asyncResult)
		{
		}

		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			error = default(int);
		}

		private static void Disconnect_icall(IntPtr sock, bool reuse, out int error)
		{
			error = default(int);
		}

		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		[CLSCompliant(false)]
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			return false;
		}

		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			errorCode = default(SocketError);
			return null;
		}

		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			return 0;
		}

		private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		[CLSCompliant(false)]
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		public bool SendAsync(SocketAsyncEventArgs e)
		{
			return false;
		}

		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			errorCode = default(SocketError);
			return null;
		}

		private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
		}

		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			errorCode = default(SocketError);
			return 0;
		}

		private unsafe static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		private unsafe static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			error = default(int);
			return 0;
		}

		public int EndSendTo(IAsyncResult asyncResult)
		{
			return 0;
		}

		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return null;
		}

		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
		{
			obj_val = null;
			error = default(int);
		}

		private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
		{
			obj_val = null;
			error = default(int);
		}

		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
		}

		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
		{
			error = default(int);
		}

		private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
		{
			error = default(int);
		}

		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return 0;
		}

		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error)
		{
			error = default(int);
			return 0;
		}

		private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error)
		{
			error = default(int);
			return 0;
		}

		public void Close()
		{
		}

		public void Close(int timeout)
		{
		}

		internal static void Close_icall(IntPtr socket, out int error)
		{
			error = default(int);
		}

		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			error = default(int);
		}

		internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error)
		{
			error = default(int);
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private void Linger(IntPtr handle)
		{
		}

		private void ThrowIfDisposedAndClosed()
		{
		}

		private void ThrowIfBufferNull(byte[] buffer)
		{
		}

		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
		{
		}

		private void ThrowIfUdp()
		{
		}

		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			return null;
		}

		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
		}

		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
		{
		}

		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			return default(SocketAsyncOperation);
		}

		private IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			return null;
		}

		internal static void cancel_blocking_socket_operation(Thread thread)
		{
		}

		private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface)
		{
			return false;
		}

		private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			return false;
		}
	}
}
