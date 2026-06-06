namespace System.ComponentModel
{
	public class DoWorkEventArgs : CancelEventArgs
	{
		private object result;

		private object argument;

		[SRDescription("Argument passed into the worker handler from BackgroundWorker.RunWorkerAsync.")]
		public object Argument => null;

		[SRDescription("Result from the worker function.")]
		public object Result
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DoWorkEventArgs(object argument)
		{
		}
	}
}
