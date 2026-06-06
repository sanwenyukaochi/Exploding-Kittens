using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
	[Serializable]
	public class NetworkInformationException : Win32Exception
	{
		public override int ErrorCode => 0;

		public NetworkInformationException()
		{
		}

		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
