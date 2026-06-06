using System.Threading.Tasks;

namespace System.Net.Sockets
{
	public class TcpClient : IDisposable
	{
		private Socket m_ClientSocket;

		private bool m_Active;

		private NetworkStream m_DataStream;

		private AddressFamily m_Family;

		private bool m_CleanedUp;

		public Socket Client
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TcpClient()
		{
		}

		public TcpClient(AddressFamily family)
		{
		}

		public void Connect(string hostname, int port)
		{
		}

		public void Connect(IPEndPoint remoteEP)
		{
		}

		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		public Task ConnectAsync(string host, int port)
		{
			return null;
		}

		public NetworkStream GetStream()
		{
			return null;
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		~TcpClient()
		{
		}

		private void initialize()
		{
		}
	}
}
