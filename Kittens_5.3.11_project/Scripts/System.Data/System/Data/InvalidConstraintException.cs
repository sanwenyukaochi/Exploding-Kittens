using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class InvalidConstraintException : DataException
	{
		protected InvalidConstraintException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public InvalidConstraintException()
			: base(null, default(StreamingContext))
		{
		}

		public InvalidConstraintException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
