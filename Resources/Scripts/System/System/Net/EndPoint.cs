using System.Net.Sockets;

namespace System.Net
{
	[Serializable]
	public abstract class EndPoint
	{
		public virtual AddressFamily AddressFamily => default(AddressFamily);

		public virtual SocketAddress Serialize()
		{
			return null;
		}

		public virtual EndPoint Create(SocketAddress socketAddress)
		{
			return null;
		}
	}
}
