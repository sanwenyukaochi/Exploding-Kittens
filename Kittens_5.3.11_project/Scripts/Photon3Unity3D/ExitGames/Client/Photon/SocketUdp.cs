using System;
using System.Net.Sockets;

namespace ExitGames.Client.Photon
{
	internal class SocketUdp : IPhotonSocket, IDisposable
	{
		private Socket sock;

		private readonly object syncer;

		public SocketUdp(PeerBase npeer)
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

		internal void DnsAndConnect()
		{
		}

		public void ReceiveLoop()
		{
		}
	}
}
