namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Animates the value of a Float Variable using an Animation Curve.")]
	[ActionCategory(ActionCategory.AnimateVariables)]
	public class AnimateFloat : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The animation curve to use.")]
		public FsmAnimationCurve animCurve;

		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to set.")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Tooltip("Optionally send an Event when the animation finishes.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		private float startTime;

		private float currentTime;

		private float endTime;

		private bool looping;

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
