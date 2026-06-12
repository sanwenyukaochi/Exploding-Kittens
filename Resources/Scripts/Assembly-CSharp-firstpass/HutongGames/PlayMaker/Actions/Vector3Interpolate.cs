namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Interpolates between 2 Vector3 values over a specified Time.")]
	public class Vector3Interpolate : FsmStateAction
	{
		[Tooltip("The type of interpolation to use.")]
		public InterpolationType mode;

		[RequiredField]
		[Tooltip("The start vector.")]
		public FsmVector3 fromVector;

		[RequiredField]
		[Tooltip("The end vector.")]
		public FsmVector3 toVector;

		[Tooltip("How long it should take to interpolate from start to end.")]
		[RequiredField]
		public FsmFloat time;

		[Tooltip("Store the interpolated vector in a Vector3 Variable.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmVector3 storeResult;

		[Tooltip("Optionally send this event when finished.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale e.g., if the game is paused.")]
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
