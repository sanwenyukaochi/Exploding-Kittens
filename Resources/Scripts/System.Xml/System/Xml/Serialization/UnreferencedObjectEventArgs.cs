namespace System.Xml.Serialization
{
	public class UnreferencedObjectEventArgs : EventArgs
	{
		private object o;

		private string id;

		public UnreferencedObjectEventArgs(object o, string id)
		{
		}
	}
}
