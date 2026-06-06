using System.Runtime.Serialization;

namespace System.Resources
{
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		public MissingManifestResourceException()
		{
		}

		public MissingManifestResourceException(string message)
		{
		}

		protected MissingManifestResourceException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
