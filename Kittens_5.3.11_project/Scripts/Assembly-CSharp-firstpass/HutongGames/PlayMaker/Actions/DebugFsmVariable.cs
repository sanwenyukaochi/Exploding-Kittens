namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Print the value of any FSM Variable in the PlayMaker Log Window.")]
	public class DebugFsmVariable : BaseLogAction
	{
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		[UIHint(UIHint.Variable)]
		[Tooltip("The variable to debug.")]
		public FsmVar variable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
