using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	public class NotSupportedException : SystemException
	{
		public NotSupportedException()
		{
		}

		public NotSupportedException(string message)
		{
		}

		public NotSupportedException(string message, Exception innerException)
		{
		}

		protected NotSupportedException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
