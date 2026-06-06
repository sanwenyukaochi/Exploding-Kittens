using System.Runtime.Serialization;

namespace System.Xml
{
	[Serializable]
	public class XmlException : SystemException
	{
		private string res;

		private string[] args;

		private int lineNumber;

		private int linePosition;

		[OptionalField]
		private string sourceUri;

		private string message;

		public int LineNumber => 0;

		public int LinePosition => 0;

		public override string Message => null;

		internal string ResString => null;

		protected XmlException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public XmlException()
		{
		}

		public XmlException(string message)
		{
		}

		public XmlException(string message, Exception innerException)
		{
		}

		public XmlException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}

		internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
		}

		internal XmlException(string res, string[] args)
		{
		}

		internal XmlException(string res, string arg)
		{
		}

		internal XmlException(string res, string arg, string sourceUri)
		{
		}

		internal XmlException(string res, string arg, IXmlLineInfo lineInfo)
		{
		}

		internal XmlException(string res, string[] args, IXmlLineInfo lineInfo)
		{
		}

		internal XmlException(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri)
		{
		}

		internal XmlException(string res, string arg, int lineNumber, int linePosition)
		{
		}

		internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
		{
		}

		internal XmlException(string res, string[] args, int lineNumber, int linePosition)
		{
		}

		internal XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri)
		{
		}

		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition)
		{
		}

		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
		}

		private static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			return null;
		}

		private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition)
		{
			return null;
		}

		internal static string[] BuildCharExceptionArgs(string data, int invCharIndex)
		{
			return null;
		}

		internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex)
		{
			return null;
		}

		internal static string[] BuildCharExceptionArgs(char invChar, char nextChar)
		{
			return null;
		}
	}
}
