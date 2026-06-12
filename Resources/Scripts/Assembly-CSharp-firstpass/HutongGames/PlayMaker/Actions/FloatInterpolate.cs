namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Interpolates between 2 Float values over a specified Time.")]
	[ActionCategory(ActionCategory.Math)]
	public class FloatInterpolate : FsmStateAction
	{
		[Tooltip("Interpolation mode: Linear or EaseInOut.")]
		public InterpolationType mode;

		[Tooltip("Interpolate from this value.")]
		[RequiredField]
		public FsmFloat fromFloat;

		[RequiredField]
		[Tooltip("Interpolate to this value.")]
		public FsmFloat toFloat;

		[RequiredField]
		[Tooltip("Interpolate over this amount of time in seconds.")]
		public FsmFloat time;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the current value in a float variable.")]
		public FsmFloat storeResult;

		[Tooltip("Event to send when the interpolation is finished.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale. Useful if the game is paused (Time scaled to 0).")]
		public bool realTime;

		private float startTime;

		private float currentTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
