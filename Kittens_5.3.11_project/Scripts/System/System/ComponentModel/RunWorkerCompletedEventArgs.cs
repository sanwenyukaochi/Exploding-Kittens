namespace System.ComponentModel
{
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object result;

		public object Result => null;

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new object UserState => null;

		public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		{
		}
	}
}
