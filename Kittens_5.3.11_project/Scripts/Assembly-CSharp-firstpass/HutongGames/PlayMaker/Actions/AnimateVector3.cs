namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Vector3 Variable using an Animation Curve.")]
	public class AnimateVector3 : AnimateFsmAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector3 Variable to animate.")]
		[RequiredField]
		public FsmVector3 vectorVariable;

		[RequiredField]
		[Tooltip("Curve to use for the X value.")]
		public FsmAnimationCurve curveX;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to vectorVariable.x.")]
		public Calculation calculationX;

		[Tooltip("Curve to use for the Y value.")]
		[RequiredField]
		public FsmAnimationCurve curveY;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to vectorVariable.y.")]
		public Calculation calculationY;

		[Tooltip("Curve to use for the Z value.")]
		[RequiredField]
		public FsmAnimationCurve curveZ;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to vectorVariable.z.")]
		public Calculation calculationZ;

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
