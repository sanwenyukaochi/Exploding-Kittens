using System.Runtime.Serialization;

namespace System.Security.Authentication
{
	[Serializable]
	public class AuthenticationException : SystemException
	{
		public AuthenticationException()
		{
		}

		public AuthenticationException(string message, Exception innerException)
		{
		}

		protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
