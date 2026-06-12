namespace System.ComponentModel
{
	public class AsyncCompletedEventArgs : EventArgs
	{
		private readonly Exception error;

		private readonly bool cancelled;

		private readonly object userState;

		[SRDescription("True if operation was cancelled.")]
		public bool Cancelled => false;

		[SRDescription("Exception that occurred during operation.  Null if no error.")]
		public Exception Error => null;

		[SRDescription("User-supplied state to identify operation.")]
		public object UserState => null;

		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AsyncCompletedEventArgs()
		{
		}

		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
		}

		protected void RaiseExceptionIfNecessary()
		{
		}
	}
}
