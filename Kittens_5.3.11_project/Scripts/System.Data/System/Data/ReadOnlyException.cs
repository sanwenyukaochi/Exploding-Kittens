using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class ReadOnlyException : DataException
	{
		protected ReadOnlyException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public ReadOnlyException()
			: base(null, default(StreamingContext))
		{
		}

		public ReadOnlyException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
