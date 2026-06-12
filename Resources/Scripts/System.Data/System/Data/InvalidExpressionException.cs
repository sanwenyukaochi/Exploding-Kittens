using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class InvalidExpressionException : DataException
	{
		protected InvalidExpressionException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public InvalidExpressionException()
			: base(null, default(StreamingContext))
		{
		}

		public InvalidExpressionException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
