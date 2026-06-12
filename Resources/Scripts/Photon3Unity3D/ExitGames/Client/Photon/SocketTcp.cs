using System;
using System.Net.Sockets;

namespace ExitGames.Client.Photon
{
	internal class SocketTcp : IPhotonSocket, IDisposable
	{
		private Socket sock;

		private readonly object syncer;

		public SocketTcp(PeerBase npeer)
			: base(null)
		{
		}

		public void Dispose()
		{
		}

		public override bool Connect()
		{
			return false;
		}

		public override bool Disconnect()
		{
			return false;
		}

		public override PhotonSocketError Send(byte[] data, int length)
		{
			return default(PhotonSocketError);
		}

		public void DnsAndConnect()
		{
		}

		public void ReceiveLoop()
		{
		}
	}
}
