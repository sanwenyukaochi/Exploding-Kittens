using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.Sockets
{
	[Serializable]
	public class SocketException : Win32Exception
	{
		[NonSerialized]
		private EndPoint m_EndPoint;

		public override int ErrorCode => 0;

		public override string Message => null;

		public SocketError SocketErrorCode => default(SocketError);

		private static int WSAGetLastError_icall()
		{
			return 0;
		}

		public SocketException()
		{
		}

		internal SocketException(int error, string message)
		{
		}

		public SocketException(int errorCode)
		{
		}

		internal SocketException(SocketError socketError)
		{
		}

		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
