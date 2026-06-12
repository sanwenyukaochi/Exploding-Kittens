using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		public CookieException()
		{
		}

		internal CookieException(string message)
		{
		}

		internal CookieException(string message, Exception inner)
		{
		}

		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
