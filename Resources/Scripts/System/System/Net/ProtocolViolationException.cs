using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	public class ProtocolViolationException : InvalidOperationException, ISerializable
	{
		public ProtocolViolationException()
		{
		}

		public ProtocolViolationException(string message)
		{
		}

		protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
