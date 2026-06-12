using System.Runtime.Serialization;

namespace System.Data
{
	[Serializable]
	public class VersionNotFoundException : DataException
	{
		protected VersionNotFoundException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public VersionNotFoundException()
			: base(null, default(StreamingContext))
		{
		}

		public VersionNotFoundException(string s)
			: base(null, default(StreamingContext))
		{
		}
	}
}
