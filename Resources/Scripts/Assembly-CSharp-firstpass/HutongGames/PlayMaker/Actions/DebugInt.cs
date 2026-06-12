namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of an Integer Variable in the PlayMaker Log Window.")]
	public class DebugInt : BaseLogAction
	{
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		[Tooltip("The Int variable to debug.")]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
