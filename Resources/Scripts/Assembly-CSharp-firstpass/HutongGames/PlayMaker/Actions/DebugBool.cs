namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Bool Variable in the PlayMaker Log Window.")]
	public class DebugBool : BaseLogAction
	{
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		[Tooltip("The Bool variable to debug.")]
		[UIHint(UIHint.Variable)]
		public FsmBool boolVariable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
