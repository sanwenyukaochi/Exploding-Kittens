using System.Runtime.Serialization;

namespace System.Xml.Schema
{
	[Serializable]
	public class XmlSchemaException : SystemException
	{
		private string res;

		private string[] args;

		private string sourceUri;

		private int lineNumber;

		private int linePosition;

		[NonSerialized]
		private XmlSchemaObject sourceSchemaObject;

		private string message;

		internal string GetRes => null;

		internal string[] Args => null;

		public string SourceUri => null;

		public int LineNumber => 0;

		public int LinePosition => 0;

		public XmlSchemaObject SourceSchemaObject => null;

		public override string Message => null;

		protected XmlSchemaException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public XmlSchemaException()
		{
		}

		public XmlSchemaException(string message)
		{
		}

		public XmlSchemaException(string message, Exception innerException)
		{
		}

		public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}

		internal XmlSchemaException(string res, string[] args)
		{
		}

		internal XmlSchemaException(string res, string arg)
		{
		}

		internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
		{
		}

		internal XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition)
		{
		}

		internal XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition)
		{
		}

		internal XmlSchemaException(string res, XmlSchemaObject source)
		{
		}

		internal XmlSchemaException(string res, string arg, XmlSchemaObject source)
		{
		}

		internal XmlSchemaException(string res, string[] args, XmlSchemaObject source)
		{
		}

		internal XmlSchemaException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source)
		{
		}

		internal static string CreateMessage(string res, string[] args)
		{
			return null;
		}

		internal void SetSource(string sourceUri, int lineNumber, int linePosition)
		{
		}

		internal void SetSchemaObject(XmlSchemaObject source)
		{
		}

		internal void SetSource(XmlSchemaObject source)
		{
		}
	}
}
