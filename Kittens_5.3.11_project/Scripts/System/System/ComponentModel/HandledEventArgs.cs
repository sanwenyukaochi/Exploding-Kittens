namespace System.ComponentModel
{
	public class HandledEventArgs : EventArgs
	{
		public bool Handled { get; set; }

		public HandledEventArgs()
		{
		}

		public HandledEventArgs(bool defaultHandledValue)
		{
		}
	}
}
