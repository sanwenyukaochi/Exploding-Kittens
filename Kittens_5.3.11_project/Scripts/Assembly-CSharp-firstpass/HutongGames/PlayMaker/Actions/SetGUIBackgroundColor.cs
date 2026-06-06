namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Tinting Color for all background elements rendered by the GUI. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	[ActionCategory(ActionCategory.GUI)]
	public class SetGUIBackgroundColor : FsmStateAction
	{
		[Tooltip("The color for all background elements.")]
		[RequiredField]
		public FsmColor backgroundColor;

		[Tooltip("Apply this setting to all GUI calls, even in other scripts.")]
		public FsmBool applyGlobally;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
