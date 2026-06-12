using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	public class ServicePoint
	{
		private readonly Uri uri;

		private DateTime lastDnsResolve;

		private Version protocolVersion;

		private IPHostEntry host;

		private bool usesProxy;

		private bool sendContinue;

		private bool useConnect;

		private object hostE;

		private bool useNagle;

		private BindIPEndPoint endPointCallback;

		private bool tcp_keepalive;

		private int tcp_keepalive_time;

		private int tcp_keepalive_interval;

		private bool disposed;

		private int connectionLeaseTimeout;

		private int receiveBufferSize;

		private int connectionLimit;

		private int maxIdleTime;

		private object m_ServerCertificateOrBytes;

		private object m_ClientCertificateOrBytes;

		internal ServicePointManager.SPKey Key { get; }

		private ServicePointScheduler Scheduler { get; set; }

		public Uri Address => null;

		public int ConnectionLimit => 0;

		public virtual Version ProtocolVersion => null;

		public bool Expect100Continue
		{
			set
			{
			}
		}

		public bool UseNagleAlgorithm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool SendContinue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool UsesProxy
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool UseConnect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool HasTimedOut => false;

		internal IPHostEntry HostEntry => null;

		internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
		{
		}

		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
		}

		internal void KeepAliveSetup(Socket socket)
		{
		}

		private static void PutBytes(byte[] bytes, uint v, int offset)
		{
		}

		internal void SetVersion(Version version)
		{
		}

		internal void SendRequest(WebOperation operation, string groupName)
		{
		}

		internal void FreeServicePoint()
		{
		}

		internal void UpdateServerCertificate(X509Certificate certificate)
		{
		}

		internal void UpdateClientCertificate(X509Certificate certificate)
		{
		}

		internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			return false;
		}
	}
}
