namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Float Variable FROM-TO with assistance of Deformation Curve.")]
	public class CurveFloat : CurveFsmAction
	{
		[Tooltip("The float variable to animate.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat floatVariable;

		[Tooltip("Animate from this value.")]
		[RequiredField]
		public FsmFloat fromValue;

		[Tooltip("Animate to this value.")]
		[RequiredField]
		public FsmFloat toValue;

		[RequiredField]
		[Tooltip("The curve to use when animating.")]
		public FsmAnimationCurve animCurve;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue and toValue.")]
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
