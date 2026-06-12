namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Rotates the GUI around a pivot point. By default only effects GUI rendered by this FSM, check Apply Globally to effect all GUI controls.")]
	[ActionCategory(ActionCategory.GUI)]
	public class RotateGUI : FsmStateAction
	{
		[Tooltip("Angle to rotate in degrees.")]
		[RequiredField]
		public FsmFloat angle;

		[RequiredField]
		[Tooltip("X coordinate of pivot.")]
		public FsmFloat pivotX;

		[Tooltip("Y coordinate of pivot.")]
		[RequiredField]
		public FsmFloat pivotY;

		[Tooltip("Use normalized screen coordinates (0-1).")]
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
