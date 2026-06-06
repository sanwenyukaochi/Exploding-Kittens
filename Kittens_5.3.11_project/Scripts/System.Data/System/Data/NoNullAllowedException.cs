using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class NoNullAllowedException : DataException
	{
		protected NoNullAllowedException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public NoNullAllowedException()
			: base(null, default(StreamingContext))
		{
		}

		public NoNullAllowedException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
