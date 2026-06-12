namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the global Alpha for the GUI. Useful for fading GUI up/down. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	[ActionCategory(ActionCategory.GUI)]
	public class SetGUIAlpha : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Set the transparency of the GUI. 1 = opaque, 0 = transparent.")]
		public FsmFloat alpha;

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
