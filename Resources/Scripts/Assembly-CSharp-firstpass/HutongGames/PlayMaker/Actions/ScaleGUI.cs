namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Scales the GUI around a pivot point. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	[ActionCategory(ActionCategory.GUI)]
	public class ScaleGUI : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Scale in x (1 = 100%)")]
		public FsmFloat scaleX;

		[RequiredField]
		[Tooltip("Scale in y (1 = 100%)")]
		public FsmFloat scaleY;

		[Tooltip("Scale around this x screen coordinate.")]
		[RequiredField]
		public FsmFloat pivotX;

		[RequiredField]
		[Tooltip("Scale around this y screen coordinate.")]
		public FsmFloat pivotY;

		[Tooltip("Pivot point uses normalized coordinates (0-1). E.g. 0.5 is the center of the screen.")]
		public bool normalized;

		[Tooltip("Apply to all GUI actions in all FSMs.")]
		public bool applyGlobally;

		private bool applied;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
