using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	public class AccessViolationException : SystemException
	{
		public AccessViolationException()
		{
		}

		protected AccessViolationException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
