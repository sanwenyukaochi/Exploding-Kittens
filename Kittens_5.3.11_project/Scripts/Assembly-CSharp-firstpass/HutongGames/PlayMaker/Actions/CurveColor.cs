using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Animates the value of a Color Variable FROM-TO with assistance of Deformation Curves.")]
	[ActionCategory(ActionCategory.AnimateVariables)]
	public class CurveColor : CurveFsmAction
	{
		[Tooltip("The Color variable to animate.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmColor colorVariable;

		[Tooltip("Animate from this color.")]
		[RequiredField]
		public FsmColor fromValue;

		[Tooltip("Animate to this color.")]
		[RequiredField]
		public FsmColor toValue;

		[Tooltip("The curve used to animate the red value.")]
		[RequiredField]
		public FsmAnimationCurve curveR;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Red and toValue.Rec.")]
		public Calculation calculationR;

		[Tooltip("The curve used to animate the green value.")]
		[RequiredField]
		public FsmAnimationCurve curveG;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Green and toValue.Green.")]
		public Calculation calculationG;

		[Tooltip("The curve used to animate the blue value.")]
		[RequiredField]
		public FsmAnimationCurve curveB;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Blue and toValue.Blue.")]
		public Calculation calculationB;

		[Tooltip("The curve used to animate the alpha value.")]
		[RequiredField]
		public FsmAnimationCurve curveA;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Alpha and toValue.Alpha.")]
		public Calculation calculationA;

		private Color clr;

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
