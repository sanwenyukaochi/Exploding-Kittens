using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	public sealed class SqlTruncateException : SqlTypeException
	{
		public SqlTruncateException()
		{
		}

		public SqlTruncateException(string message)
		{
		}

		public SqlTruncateException(string message, Exception e)
		{
		}

		private SqlTruncateException(SerializationInfo si, StreamingContext sc)
		{
		}

		private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			return null;
		}
	}
}
