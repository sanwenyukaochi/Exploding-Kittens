using System.Collections.Generic;
using System.Diagnostics;

namespace ExitGames.Client.Photon.Chat
{
	public class ChatPeer : PhotonPeer
	{
		public const string NameServerHost = "ns.exitgames.com";

		public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		public string NameServerAddress => null;

		internal virtual bool IsProtocolSecure => false;

		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol)
			: base(default(ConnectionProtocol))
		{
		}

		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		private string GetNameServerAddress()
		{
			return null;
		}

		public bool Connect()
		{
			return false;
		}

		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues)
		{
			return false;
		}
	}
}
