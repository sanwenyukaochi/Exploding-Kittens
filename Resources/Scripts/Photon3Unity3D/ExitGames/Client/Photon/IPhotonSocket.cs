using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public abstract class IPhotonSocket
	{
		protected internal PeerBase peerBase;

		protected readonly ConnectionProtocol Protocol;

		public bool PollReceive;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static string _003CServerIpAddress_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003CUrlProtocol_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003CUrlPath_003Ek__BackingField;

		protected IPhotonPeerListener Listener => null;

		protected internal int MTU => 0;

		public PhotonSocketState State { get; protected set; }

		public bool Connected => false;

		public string ServerAddress { get; protected set; }

		private static string ServerIpAddress
		{
			[CompilerGenerated]
			set
			{
				_003CServerIpAddress_003Ek__BackingField = value;
			}
		}

		public int ServerPort { get; protected set; }

		public bool AddressResolvedAsIpv6 { get; protected internal set; }

		protected string UrlProtocol
		{
			[CompilerGenerated]
			set
			{
				_003CUrlProtocol_003Ek__BackingField = value;
			}
		}

		protected string UrlPath
		{
			[CompilerGenerated]
			set
			{
				_003CUrlPath_003Ek__BackingField = value;
			}
		}

		public IPhotonSocket(PeerBase peerBase)
		{
		}

		public virtual bool Connect()
		{
			return false;
		}

		public abstract bool Disconnect();

		public abstract PhotonSocketError Send(byte[] data, int length);

		public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused)
		{
		}

		public bool ReportDebugOfLevel(DebugLevel levelOfMessage)
		{
			return false;
		}

		public void EnqueueDebugReturn(DebugLevel debugLevel, string message)
		{
		}

		protected internal void HandleException(StatusCode statusCode)
		{
		}

		protected internal bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath)
		{
			address = null;
			port = default(ushort);
			urlProtocol = null;
			urlPath = null;
			return false;
		}

		protected internal bool IsIpv6SimpleCheck(IPAddress address)
		{
			return false;
		}

		protected internal static IPAddress GetIpAddress(string address)
		{
			return null;
		}
	}
}
