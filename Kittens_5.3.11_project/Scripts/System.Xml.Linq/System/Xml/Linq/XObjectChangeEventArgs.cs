namespace System.Xml.Linq
{
	public class XObjectChangeEventArgs : EventArgs
	{
		private XObjectChange _objectChange;

		public static readonly XObjectChangeEventArgs Add;

		public static readonly XObjectChangeEventArgs Remove;

		public static readonly XObjectChangeEventArgs Name;

		public static readonly XObjectChangeEventArgs Value;

		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
		}
	}
}
