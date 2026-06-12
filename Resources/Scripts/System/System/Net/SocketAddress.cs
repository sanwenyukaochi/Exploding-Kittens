using System.Net.Sockets;

namespace System.Net
{
	public class SocketAddress
	{
		internal int m_Size;

		internal byte[] m_Buffer;

		private bool m_changed;

		private int m_hash;

		public AddressFamily Family => default(AddressFamily);

		public int Size => 0;

		public byte this[int offset] => 0;

		public SocketAddress(AddressFamily family, int size)
		{
		}

		internal SocketAddress(IPAddress ipAddress)
		{
		}

		internal SocketAddress(IPAddress ipaddress, int port)
		{
		}

		internal IPAddress GetIPAddress()
		{
			return null;
		}

		internal IPEndPoint GetIPEndPoint()
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

		public override string ToString()
		{
			return null;
		}
	}
}
