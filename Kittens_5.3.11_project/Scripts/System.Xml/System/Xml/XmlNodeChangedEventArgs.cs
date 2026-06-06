namespace System.Xml
{
	public class XmlNodeChangedEventArgs : EventArgs
	{
		private XmlNodeChangedAction action;

		private XmlNode node;

		private XmlNode oldParent;

		private XmlNode newParent;

		private string oldValue;

		private string newValue;

		public XmlNodeChangedAction Action => default(XmlNodeChangedAction);

		public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
		}
	}
}
