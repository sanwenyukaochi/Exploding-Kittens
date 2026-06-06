namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Animates the value of a Rect Variable using an Animation Curve.")]
	[ActionCategory("AnimateVariables")]
	public class AnimateRect : AnimateFsmAction
	{
		[RequiredField]
		[Tooltip("The Rect Variable to animate.")]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		[Tooltip("Curve to use for the X value.")]
		[RequiredField]
		public FsmAnimationCurve curveX;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.x.")]
		public Calculation calculationX;

		[Tooltip("Curve to use for the Y value.")]
		[RequiredField]
		public FsmAnimationCurve curveY;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.y.")]
		public Calculation calculationY;

		[RequiredField]
		[Tooltip("Curve to use for the Width.")]
		public FsmAnimationCurve curveW;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.width.")]
		public Calculation calculationW;

		[RequiredField]
		[Tooltip("Curve to use for the Height.")]
		public FsmAnimationCurve curveH;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.height.")]
		public Calculation calculationH;

		private bool finishInNextStep;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void UpdateVariableValue()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
