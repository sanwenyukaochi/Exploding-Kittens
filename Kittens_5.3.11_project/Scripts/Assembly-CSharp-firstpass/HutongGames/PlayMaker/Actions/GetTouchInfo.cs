namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets info on a touch event.")]
	public class GetTouchInfo : FsmStateAction
	{
		[Tooltip("Filter by a Finger ID. You can store a Finger ID in other Touch actions, e.g., Touch Event.")]
		public FsmInt fingerId;

		[Tooltip("If true, all screen coordinates are returned normalized (0-1), otherwise in pixels.")]
		public FsmBool normalize;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the position of the touch in a Vector3 Variable.")]
		public FsmVector3 storePosition;

		[Tooltip("Store the X position \u00a0in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Y position \u00a0in a Float Variable.")]
		public FsmFloat storeY;

		[Tooltip("Store the movement of the touch in a Vector3 Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeDeltaPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the X movement in a Float Variable.")]
		public FsmFloat storeDeltaX;

		[Tooltip("Store the Y movement in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDeltaY;

		[Tooltip("Store the time between touch events in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDeltaTime;

		[Tooltip("Store the number of tap count of the touch (e.g. 2 = double tap).")]
		[UIHint(UIHint.Variable)]
		public FsmInt storeTapCount;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private float screenWidth;

		private float screenHeight;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetTouchInfo()
		{
		}
	}
}
