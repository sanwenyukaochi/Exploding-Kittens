namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Interpolates between 2 Vector2 values over a specified Time.")]
	public class Vector2Interpolate : FsmStateAction
	{
		[Tooltip("The interpolation type")]
		public InterpolationType mode;

		[Tooltip("The vector to interpolate from")]
		[RequiredField]
		public FsmVector2 fromVector;

		[RequiredField]
		[Tooltip("The vector to interpolate to")]
		public FsmVector2 toVector;

		[RequiredField]
		[Tooltip("the interpolate time")]
		public FsmFloat time;

		[Tooltip("the interpolated result")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmVector2 storeResult;

		[Tooltip("This event is fired when the interpolation is done.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale")]
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
