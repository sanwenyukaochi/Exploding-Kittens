namespace System.Xml.Serialization
{
	public class XmlNodeEventArgs : EventArgs
	{
		private object o;

		private XmlNode xmlNode;

		private int lineNumber;

		private int linePosition;

		internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o)
		{
		}
	}
}
