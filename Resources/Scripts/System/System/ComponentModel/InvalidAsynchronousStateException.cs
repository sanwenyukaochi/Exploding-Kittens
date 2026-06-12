using System.Runtime.Serialization;

namespace System.ComponentModel
{
	[Serializable]
	public class InvalidAsynchronousStateException : ArgumentException
	{
		public InvalidAsynchronousStateException()
		{
		}

		public InvalidAsynchronousStateException(string message)
		{
		}

		public InvalidAsynchronousStateException(string message, Exception innerException)
		{
		}

		protected InvalidAsynchronousStateException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
