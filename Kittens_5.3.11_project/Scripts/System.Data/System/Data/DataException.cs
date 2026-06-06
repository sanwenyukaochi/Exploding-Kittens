using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class DataException : SystemException
	{
		protected DataException(SerializationInfo info, StreamingContext context)
		{
		}

		public DataException()
		{
		}

		public DataException(string s)
		{
		}

		public DataException(string s, Exception innerException)
		{
		}
	}
}
