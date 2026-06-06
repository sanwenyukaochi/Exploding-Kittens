using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class InRowChangingEventException : DataException
	{
		protected InRowChangingEventException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public InRowChangingEventException()
			: base(null, default(StreamingContext))
		{
		}

		public InRowChangingEventException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
