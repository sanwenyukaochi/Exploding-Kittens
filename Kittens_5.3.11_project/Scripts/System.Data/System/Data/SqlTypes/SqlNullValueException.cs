using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	public sealed class SqlNullValueException : SqlTypeException
	{
		public SqlNullValueException()
		{
		}

		public SqlNullValueException(string message)
		{
		}

		public SqlNullValueException(string message, Exception e)
		{
		}

		private SqlNullValueException(SerializationInfo si, StreamingContext sc)
		{
		}

		private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			return null;
		}
	}
}
