using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	public sealed class InsufficientExecutionStackException : SystemException
	{
		public InsufficientExecutionStackException()
		{
		}

		internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
