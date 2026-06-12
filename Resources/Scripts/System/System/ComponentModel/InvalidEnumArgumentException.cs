using System.Runtime.Serialization;

namespace System.ComponentModel
{
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		public InvalidEnumArgumentException()
		{
		}

		public InvalidEnumArgumentException(string message)
		{
		}

		public InvalidEnumArgumentException(string message, Exception innerException)
		{
		}

		public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
		{
		}

		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
