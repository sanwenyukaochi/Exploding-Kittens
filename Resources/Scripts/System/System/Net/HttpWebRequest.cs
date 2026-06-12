using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		private enum NtlmAuthState
		{
			None = 0,
			Challenge = 1,
			Response = 2
		}

		private struct AuthorizationState
		{
			private readonly HttpWebRequest request;

			private readonly bool isProxy;

			private bool isCompleted;

			private NtlmAuthState ntlm_auth_state;

			public bool IsCompleted => false;

			public NtlmAuthState NtlmAuthState => default(NtlmAuthState);

			public bool IsNtlmAuthenticated => false;

			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
				this.request = null;
				this.isProxy = false;
				isCompleted = false;
				ntlm_auth_state = default(NtlmAuthState);
			}

			public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				return false;
			}

			public void Reset()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunWithTimeoutWorker_003Ed__241<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			public Task<T> workerTask;

			public int timeout;

			public CancellationTokenSource cts;

			public Action abort;

			public Func<bool> aborted;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
		private struct _003CMyGetResponseAsync_003Ed__243 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<HttpWebResponse> _003C_003Et__builder;

			public HttpWebRequest _003C_003E4__this;

			public CancellationToken cancellationToken;

			private WebCompletionSource _003Ccompletion_003E5__2;

			private WebOperation _003Coperation_003E5__3;

			private WebException _003CthrowMe_003E5__4;

			private HttpWebResponse _003Cresponse_003E5__5;

			private WebResponseStream _003Cstream_003E5__6;

			private bool _003Credirect_003E5__7;

			private bool _003CmustReadAll_003E5__8;

			private WebOperation _003Cntlm_003E5__9;

			private BufferOffsetSize _003CwriteBuffer_003E5__10;

			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			private TaskAwaiter<WebResponseStream> _003C_003Eu__3;

			private ConfiguredTaskAwaitable<(HttpWebResponse response, bool redirect, bool mustReadAll, BufferOffsetSize writeBuffer, WebOperation ntlm)>.ConfiguredTaskAwaiter _003C_003Eu__4;

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
		private struct _003CGetResponseFromData_003Ed__244 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(HttpWebResponse response, bool redirect, bool mustReadAll, BufferOffsetSize writeBuffer, WebOperation ntlm)> _003C_003Et__builder;

			public HttpWebRequest _003C_003E4__this;

			public WebResponseStream stream;

			public CancellationToken cancellationToken;

			private HttpWebResponse _003Cresponse_003E5__2;

			private WebException _003CthrowMe_003E5__3;

			private bool _003Credirect_003E5__4;

			private bool _003CmustReadAll_003E5__5;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter _003C_003Eu__2;

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

		private Uri requestUri;

		private Uri actualUri;

		private bool hostChanged;

		private bool allowAutoRedirect;

		private bool allowBuffering;

		private X509CertificateCollection certificates;

		private string connectionGroup;

		private bool haveContentLength;

		private long contentLength;

		private HttpContinueDelegate continueDelegate;

		private CookieContainer cookieContainer;

		private ICredentials credentials;

		private bool haveResponse;

		private bool requestSent;

		private WebHeaderCollection webHeaders;

		private bool keepAlive;

		private int maxAutoRedirect;

		private string mediaType;

		private string method;

		private string initialMethod;

		private bool pipelined;

		private bool preAuthenticate;

		private bool usedPreAuth;

		private Version version;

		private bool force_version;

		private Version actualVersion;

		private IWebProxy proxy;

		private bool sendChunked;

		private ServicePoint servicePoint;

		private int timeout;

		private int continueTimeout;

		private WebRequestStream writeStream;

		private HttpWebResponse webResponse;

		private WebCompletionSource responseTask;

		private WebOperation currentOperation;

		private int aborted;

		private bool gotRequestStream;

		private int redirects;

		private bool expectContinue;

		private bool getResponseCalled;

		private object locker;

		private bool finished_reading;

		private DecompressionMethods auto_decomp;

		private static int defaultMaxResponseHeadersLength;

		private static int defaultMaximumErrorResponseLength;

		private static RequestCachePolicy defaultCachePolicy;

		private int readWriteTimeout;

		private MobileTlsProvider tlsProvider;

		private MonoTlsSettings tlsSettings;

		private ServerCertValidationCallback certValidationCallback;

		private bool hostHasPort;

		private Uri hostUri;

		private AuthorizationState auth_state;

		private AuthorizationState proxy_auth_state;

		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		private bool unsafe_auth_blah;

		public Uri Address => null;

		public virtual bool AllowWriteStreamBuffering => false;

		public DecompressionMethods AutomaticDecompression => default(DecompressionMethods);

		internal bool InternalAllowBuffering => false;

		private bool MethodWithBuffer => false;

		internal MobileTlsProvider TlsProvider => null;

		internal MonoTlsSettings TlsSettings => null;

		public X509CertificateCollection ClientCertificates => null;

		public override long ContentLength => 0L;

		internal long InternalContentLength
		{
			set
			{
			}
		}

		internal bool ThrowOnError { get; set; }

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

		[System.MonoTODO]
		public static int DefaultMaximumErrorResponseLength => 0;

		public override WebHeaderCollection Headers => null;

		public string Host => null;

		public bool KeepAlive => false;

		public int ReadWriteTimeout => 0;

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

		public Version ProtocolVersion => null;

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

		public override Uri RequestUri => null;

		public bool SendChunked => false;

		public ServicePoint ServicePoint => null;

		internal ServicePoint ServicePointNoLock => null;

		public override int Timeout => 0;

		public string TransferEncoding => null;

		public override bool UseDefaultCredentials => false;

		public bool UnsafeAuthenticatedConnectionSharing => false;

		internal bool ExpectContinue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Uri AuthUri => null;

		internal bool ProxyQuery => false;

		internal ServerCertValidationCallback ServerCertValidationCallback => null;

		internal bool FinishedReading
		{
			set
			{
			}
		}

		internal bool Aborted => false;

		static HttpWebRequest()
		{
		}

		public HttpWebRequest(Uri uri)
		{
		}

		[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		private void ResetAuthorization()
		{
		}

		internal ServicePoint GetServicePoint()
		{
			return null;
		}

		private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRunWithTimeoutWorker_003Ed__241<>))]
		private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			return null;
		}

		private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CMyGetResponseAsync_003Ed__243))]
		private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetResponseFromData_003Ed__244))]
		private Task<(HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation)> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Exception FlattenException(Exception e)
		{
			return null;
		}

		private WebException GetWebException(Exception e)
		{
			return null;
		}

		private static WebException GetWebException(Exception e, bool aborted)
		{
			return null;
		}

		internal static WebException CreateRequestAbortedException()
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

		public override WebResponse GetResponse()
		{
			return null;
		}

		public override void Abort()
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		private void CheckRequestStarted()
		{
		}

		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
		}

		private void RewriteRedirectToGet()
		{
		}

		private bool Redirect(HttpStatusCode code, WebResponse response)
		{
			return false;
		}

		private string GetHeaders()
		{
			return null;
		}

		private void DoPreAuthenticate()
		{
		}

		internal byte[] GetRequestHeaders()
		{
			return null;
		}

		private (WebOperation, bool) HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			return default((WebOperation, bool));
		}

		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			return false;
		}

		private (Task<BufferOffsetSize>, WebException) GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			return default((Task<BufferOffsetSize>, WebException));
		}

		private (bool, bool, Task<BufferOffsetSize>, WebException) CheckFinalStatus(HttpWebResponse response)
		{
			return default((bool, bool, Task<BufferOffsetSize>, WebException));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		public HttpWebRequest()
		{
		}
	}
}
