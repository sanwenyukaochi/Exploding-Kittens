using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	public sealed class FtpWebRequest : WebRequest
	{
		private enum RequestStage
		{
			CheckForError = 0,
			RequestStarted = 1,
			WriteReady = 2,
			ReadReady = 3,
			ReleaseConnection = 4
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateConnectionAsync_003Ed__86 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FtpWebRequest _003C_003E4__this;

			private TcpClient _003Cclient_003E5__2;

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

		private object _syncObject;

		private ICredentials _authInfo;

		private readonly Uri _uri;

		private FtpMethodInfo _methodInfo;

		private string _renameTo;

		private bool _getRequestStreamStarted;

		private bool _getResponseStarted;

		private DateTime _startTime;

		private int _timeout;

		private int _remainingTimeout;

		private long _contentLength;

		private long _contentOffset;

		private X509CertificateCollection _clientCertificates;

		private bool _passive;

		private bool _binary;

		private bool _async;

		private bool _aborted;

		private bool _timedOut;

		private Exception _exception;

		private TimerThread.Queue _timerQueue;

		private TimerThread.Callback _timerCallback;

		private bool _enableSsl;

		private FtpControlStream _connection;

		private Stream _stream;

		private RequestStage _requestStage;

		private bool _onceFailed;

		private WebHeaderCollection _ftpRequestHeaders;

		private FtpWebResponse _ftpWebResponse;

		private int _readWriteTimeout;

		private ContextAwareResult _writeAsyncResult;

		private LazyAsyncResult _readAsyncResult;

		private LazyAsyncResult _requestCompleteAsyncResult;

		private static readonly NetworkCredential s_defaultFtpNetworkCredential;

		private static readonly TimerThread.Queue s_DefaultTimerQueue;

		internal FtpMethodInfo MethodInfo => null;

		public override string Method
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string RenameTo => null;

		public override ICredentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Uri RequestUri => null;

		public override int Timeout => 0;

		internal int RemainingTimeout => 0;

		public int ReadWriteTimeout => 0;

		public long ContentOffset => 0L;

		public override long ContentLength => 0L;

		public override IWebProxy Proxy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool Aborted => false;

		private TimerThread.Queue TimerQueue => null;

		public override RequestCachePolicy CachePolicy
		{
			set
			{
			}
		}

		public bool UseBinary => false;

		public bool UsePassive => false;

		public X509CertificateCollection ClientCertificates => null;

		public bool EnableSsl => false;

		public override WebHeaderCollection Headers => null;

		public override bool UseDefaultCredentials => false;

		private bool InUse => false;

		internal FtpWebRequest(Uri uri)
		{
		}

		public override WebResponse GetResponse()
		{
			return null;
		}

		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		private void SubmitRequest(bool isAsync)
		{
		}

		private Exception TranslateConnectException(Exception e)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateConnectionAsync_003Ed__86))]
		private void CreateConnectionAsync()
		{
		}

		private FtpControlStream CreateConnection()
		{
			return null;
		}

		private Stream TimedSubmitRequestHelper(bool isAsync)
		{
			return null;
		}

		private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
		{
		}

		private bool AttemptedRecovery(Exception e)
		{
			return false;
		}

		private void SetException(Exception exception)
		{
		}

		private void CheckError()
		{
		}

		internal void RequestCallback(object obj)
		{
		}

		private void SyncRequestCallback(object obj)
		{
		}

		private void AsyncRequestCallback(object obj)
		{
		}

		private RequestStage FinishRequestStage(RequestStage stage)
		{
			return default(RequestStage);
		}

		public override void Abort()
		{
		}

		private void EnsureFtpWebResponse(Exception exception)
		{
		}

		internal void DataStreamClosed(CloseExState closeState)
		{
		}
	}
}
