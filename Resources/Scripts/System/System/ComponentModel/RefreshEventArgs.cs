namespace System.ComponentModel
{
	public class RefreshEventArgs : EventArgs
	{
		public object ComponentChanged { get; }

		public Type TypeChanged { get; }

		public RefreshEventArgs(object componentChanged)
		{
		}

		public RefreshEventArgs(Type typeChanged)
		{
		}
	}
}
