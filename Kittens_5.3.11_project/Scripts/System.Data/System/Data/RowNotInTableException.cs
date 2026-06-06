using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class RowNotInTableException : DataException
	{
		protected RowNotInTableException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public RowNotInTableException()
			: base(null, default(StreamingContext))
		{
		}

		public RowNotInTableException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
