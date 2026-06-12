namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Float Variable using an Animation Curve.")]
	public class AnimateFloatV2 : AnimateFsmAction
	{
		[RequiredField]
		[Tooltip("The float variable to animate.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		[Tooltip("The animation curve to use.")]
		[RequiredField]
		public FsmAnimationCurve animCurve;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to floatVariable")]
		public Calculation calculation;

		private bool finishInNextStep;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
