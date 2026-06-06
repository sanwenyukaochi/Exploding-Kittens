using System.Runtime.Serialization;

namespace System.Xml.Schema
{
	[Serializable]
	public class XmlSchemaInferenceException : XmlSchemaException
	{
		protected XmlSchemaInferenceException(SerializationInfo info, StreamingContext context)
			: base(null, default(StreamingContext))
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public XmlSchemaInferenceException()
			: base(null, default(StreamingContext))
		{
		}

		internal XmlSchemaInferenceException(string res, string arg)
			: base(null, default(StreamingContext))
		{
		}

		internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition)
			: base(null, default(StreamingContext))
		{
		}
	}
}
