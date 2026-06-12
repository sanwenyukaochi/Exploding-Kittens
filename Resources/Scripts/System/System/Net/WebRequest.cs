using System.Collections;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading.Tasks;

namespace System.Net
{
	[Serializable]
	public abstract class WebRequest : MarshalByRefObject, ISerializable
	{
		internal class DesignerWebRequestCreate : IWebRequestCreate
		{
			public WebRequest Create(Uri uri)
			{
				return null;
			}
		}

		private static ArrayList s_PrefixList;

		private static object s_InternalSyncObject;

		private static TimerThread.Queue s_DefaultTimerQueue;

		private AuthenticationLevel m_AuthenticationLevel;

		private TokenImpersonationLevel m_ImpersonationLevel;

		private RequestCachePolicy m_CachePolicy;

		private RequestCacheProtocol m_CacheProtocol;

		private RequestCacheBinding m_CacheBinding;

		private static DesignerWebRequestCreate webRequestCreate;

		private static IWebProxy s_DefaultWebProxy;

		private static bool s_DefaultWebProxyInitialized;

		private static object InternalSyncObject => null;

		internal static ArrayList PrefixList => null;

		public virtual RequestCachePolicy CachePolicy
		{
			set
			{
			}
		}

		public virtual string Method
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Uri RequestUri => null;

		public virtual WebHeaderCollection Headers => null;

		public virtual long ContentLength => 0L;

		public virtual ICredentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool UseDefaultCredentials => false;

		public virtual IWebProxy Proxy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual int Timeout => 0;

		internal RequestCacheProtocol CacheProtocol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static IWebProxy InternalDefaultWebProxy => null;

		private static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			return null;
		}

		public static WebRequest Create(string requestUriString)
		{
			return null;
		}

		public static WebRequest Create(Uri requestUri)
		{
			return null;
		}

		private static ArrayList PopulatePrefixList()
		{
			return null;
		}

		protected WebRequest()
		{
		}

		protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		private void InternalSetCachePolicy(RequestCachePolicy policy)
		{
		}

		public virtual WebResponse GetResponse()
		{
			return null;
		}

		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		public virtual Task<WebResponse> GetResponseAsync()
		{
			return null;
		}

		private WindowsIdentity SafeCaptureIdenity()
		{
			return null;
		}

		public virtual void Abort()
		{
		}
	}
}
