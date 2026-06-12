namespace System.Threading
{
	public sealed class ManualResetEvent : EventWaitHandle
	{
		public ManualResetEvent(bool initialState)
			: base(initialState: false, default(EventResetMode))
		{
		}
	}
}
