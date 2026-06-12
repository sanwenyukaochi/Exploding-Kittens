using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	public class InvalidCastException : SystemException
	{
		public InvalidCastException()
		{
		}

		public InvalidCastException(string message)
		{
		}

		public InvalidCastException(string message, Exception innerException)
		{
		}

		protected InvalidCastException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
