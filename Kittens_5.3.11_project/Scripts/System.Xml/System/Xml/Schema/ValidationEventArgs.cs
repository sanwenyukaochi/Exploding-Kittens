namespace System.Xml.Schema
{
	public class ValidationEventArgs : EventArgs
	{
		private XmlSchemaException ex;

		private XmlSeverityType severity;

		public XmlSeverityType Severity => default(XmlSeverityType);

		public XmlSchemaException Exception => null;

		internal ValidationEventArgs(XmlSchemaException ex)
		{
		}

		internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity)
		{
		}
	}
}
