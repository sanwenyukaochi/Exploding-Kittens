using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("AnimateVariables")]
	[Tooltip("Animates the value of a Rect Variable FROM-TO with assistance of Deformation Curves.")]
	public class CurveRect : CurveFsmAction
	{
		[Tooltip("The Rect Variable to animate.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		[RequiredField]
		[Tooltip("The Rect to animate from.")]
		public FsmRect fromValue;

		[RequiredField]
		[Tooltip("The Rect to animate to.")]
		public FsmRect toValue;

		[RequiredField]
		[Tooltip("Curve that controls the X value.")]
		public FsmAnimationCurve curveX;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.x and toValue.x.")]
		public Calculation calculationX;

		[RequiredField]
		[Tooltip("Curve that controls the Y value.")]
		public FsmAnimationCurve curveY;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.y and toValue.y.")]
		public Calculation calculationY;

		[RequiredField]
		[Tooltip("Curve that controls the Width.")]
		public FsmAnimationCurve curveW;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.width and toValue.width.")]
		public Calculation calculationW;

		[RequiredField]
		[Tooltip("Curve that controls the Height.")]
		public FsmAnimationCurve curveH;

		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.height and toValue.height.")]
		public Calculation calculationH;

		private Rect rct;

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
