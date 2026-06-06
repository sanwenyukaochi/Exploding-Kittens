namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Float Variable in the PlayMaker Log Window.")]
	public class DebugFloat : BaseLogAction
	{
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		[Tooltip("The Float variable to debug.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
