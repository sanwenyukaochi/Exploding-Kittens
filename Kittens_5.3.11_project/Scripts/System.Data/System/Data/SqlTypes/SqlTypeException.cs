using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	public class SqlTypeException : SystemException
	{
		public SqlTypeException()
		{
		}

		public SqlTypeException(string message)
		{
		}

		public SqlTypeException(string message, Exception e)
		{
		}

		protected SqlTypeException(SerializationInfo si, StreamingContext sc)
		{
		}

		private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			return null;
		}
	}
}
