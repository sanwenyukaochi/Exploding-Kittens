using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	[Serializable]
	public class ExternalException : SystemException
	{
		public virtual int ErrorCode => 0;

		public ExternalException()
		{
		}

		public ExternalException(string message)
		{
		}

		public ExternalException(string message, Exception inner)
		{
		}

		public ExternalException(string message, int errorCode)
		{
		}

		protected ExternalException(SerializationInfo info, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
