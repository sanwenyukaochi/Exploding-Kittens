using System.Runtime.Serialization;

namespace System.ComponentModel
{
	[Serializable]
	public class WarningException : SystemException
	{
		public string HelpUrl { get; }

		public string HelpTopic { get; }

		public WarningException()
		{
		}

		public WarningException(string message)
		{
		}

		public WarningException(string message, string helpUrl)
		{
		}

		public WarningException(string message, Exception innerException)
		{
		}

		public WarningException(string message, string helpUrl, string helpTopic)
		{
		}

		protected WarningException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
