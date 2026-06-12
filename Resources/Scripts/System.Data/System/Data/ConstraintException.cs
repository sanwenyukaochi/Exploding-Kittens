using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class ConstraintException : DataException
	{
		protected ConstraintException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public ConstraintException()
			: base(null, default(StreamingContext))
		{
		}

		public ConstraintException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
