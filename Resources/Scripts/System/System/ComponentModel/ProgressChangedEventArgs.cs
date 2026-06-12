namespace System.ComponentModel
{
	public class ProgressChangedEventArgs : EventArgs
	{
		private readonly int progressPercentage;

		private readonly object userState;

		[SRDescription("Percentage progress made in operation.")]
		public int ProgressPercentage => 0;

		[SRDescription("User-supplied state to identify operation.")]
		public object UserState => null;

		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
		}
	}
}
