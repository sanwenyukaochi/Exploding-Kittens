using System.Net.Sockets;

namespace System.Net
{
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		private IPAddress _address;

		private int _port;

		internal static IPEndPoint Any;

		internal static IPEndPoint IPv6Any;

		public override AddressFamily AddressFamily => default(AddressFamily);

		public IPAddress Address => null;

		public int Port => 0;

		public IPEndPoint(IPAddress address, int port)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override SocketAddress Serialize()
		{
			return null;
		}

		public override EndPoint Create(SocketAddress socketAddress)
		{
			return null;
		}

		public override bool Equals(object comparand)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
