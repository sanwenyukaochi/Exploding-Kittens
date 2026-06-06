using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class DeletedRowInaccessibleException : DataException
	{
		protected DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public DeletedRowInaccessibleException()
			: base(null, default(StreamingContext))
		{
		}

		public DeletedRowInaccessibleException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
