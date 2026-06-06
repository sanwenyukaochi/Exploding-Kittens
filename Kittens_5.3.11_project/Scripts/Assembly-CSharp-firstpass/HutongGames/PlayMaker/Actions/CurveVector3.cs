using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Vector3 Variable FROM-TO with assistance of Deformation Curves.")]
	public class CurveVector3 : CurveFsmAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector3 variable to animate.")]
		public FsmVector3 vectorVariable;

		[Tooltip("Animate from this value.")]
		[RequiredField]
		public FsmVector3 fromValue;

		[RequiredField]
		[Tooltip("Animate to this value.")]
		public FsmVector3 toValue;

		[RequiredField]
		[Tooltip("Curve that controls the X value.")]
		public FsmAnimationCurve curveX;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.x and toValue.x.")]
		public Calculation calculationX;

		[Tooltip("Curve that controls the Y value.")]
		[RequiredField]
		public FsmAnimationCurve curveY;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.y and toValue.y.")]
		public Calculation calculationY;

		[Tooltip("Curve that controls the Z value.")]
		[RequiredField]
		public FsmAnimationCurve curveZ;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.z and toValue.z.")]
		public Calculation calculationZ;

		private Vector3 vct;

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
