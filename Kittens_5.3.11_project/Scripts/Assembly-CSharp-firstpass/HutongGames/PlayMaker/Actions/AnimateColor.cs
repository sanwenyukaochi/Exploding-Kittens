namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Color Variable using an Animation Curve.")]
	public class AnimateColor : AnimateFsmAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Color Variable to animate.")]
		[RequiredField]
		public FsmColor colorVariable;

		[RequiredField]
		[Tooltip("The curve used to animate the red value.")]
		public FsmAnimationCurve curveR;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to the red channel.")]
		public Calculation calculationR;

		[Tooltip("The curve used to animate the green value.")]
		[RequiredField]
		public FsmAnimationCurve curveG;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to the green channel.")]
		public Calculation calculationG;

		[Tooltip("The curve used to animate the blue value.")]
		[RequiredField]
		public FsmAnimationCurve curveB;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to the blue channel.")]
		public Calculation calculationB;

		[Tooltip("The curve used to animate the alpha value.")]
		[RequiredField]
		public FsmAnimationCurve curveA;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to the alpha channel.")]
		public Calculation calculationA;

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
