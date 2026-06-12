using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class SyntaxErrorException : InvalidExpressionException
	{
		protected SyntaxErrorException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public SyntaxErrorException()
			: base(null, default(StreamingContext))
		{
		}

		public SyntaxErrorException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
