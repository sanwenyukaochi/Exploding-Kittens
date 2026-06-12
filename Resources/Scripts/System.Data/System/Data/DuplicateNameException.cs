using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class DuplicateNameException : DataException
	{
		protected DuplicateNameException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public DuplicateNameException()
			: base(null, default(StreamingContext))
		{
		}

		public DuplicateNameException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
