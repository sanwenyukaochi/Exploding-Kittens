namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends events based on the direction of Input Axis (Left/Right/Up/Down...).")]
	public class AxisEvent : FsmStateAction
	{
		[Tooltip("Horizontal axis as defined in the Input Manager")]
		public FsmString horizontalAxis;

		[Tooltip("Vertical axis as defined in the Input Manager")]
		public FsmString verticalAxis;

		[Tooltip("Event to send if input is to the left.")]
		public FsmEvent leftEvent;

		[Tooltip("Event to send if input is to the right.")]
		public FsmEvent rightEvent;

		[Tooltip("Event to send if input is to the up.")]
		public FsmEvent upEvent;

		[Tooltip("Event to send if input is to the down.")]
		public FsmEvent downEvent;

		[Tooltip("Event to send if input is in any direction.")]
		public FsmEvent anyDirection;

		[Tooltip("Event to send if no axis input (centered).")]
		public FsmEvent noDirection;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
