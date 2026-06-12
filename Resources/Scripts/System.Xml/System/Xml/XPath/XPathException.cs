using System.Runtime.Serialization;

namespace System.Xml.XPath
{
	[Serializable]
	public class XPathException : SystemException
	{
		private string res;

		private string[] args;

		private string message;

		public override string Message => null;

		protected XPathException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public XPathException()
		{
		}

		public XPathException(string message, Exception innerException)
		{
		}

		internal static XPathException Create(string res)
		{
			return null;
		}

		internal static XPathException Create(string res, string arg)
		{
			return null;
		}

		internal static XPathException Create(string res, string arg, string arg2)
		{
			return null;
		}

		private XPathException(string res, string[] args)
		{
		}

		private XPathException(string res, string[] args, Exception inner)
		{
		}

		private static string CreateMessage(string res, string[] args)
		{
			return null;
		}
	}
}
