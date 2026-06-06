namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Logs the value of an Enum Variable in the PlayMaker Log Window.")]
	[ActionCategory(ActionCategory.Debug)]
	public class DebugEnum : BaseLogAction
	{
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		[Tooltip("The Enum Variable to debug.")]
		[UIHint(UIHint.Variable)]
		public FsmEnum enumVariable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
