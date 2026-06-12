using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Sets a Vector2 Variable to a random value.")]
	public class Vector2RandomValue : FsmStateAction
	{
		public enum Option
		{
			Circle = 0,
			Rectangle = 1,
			InArc = 2,
			AtAngles = 3
		}

		private static bool showPreview;

		[PreviewField("DrawPreview")]
		[Tooltip("Controls the distribution of the random Vector2 values.")]
		public Option shape;

		[Tooltip("The minimum length for the random Vector2 value.")]
		public FsmFloat minLength;

		[Tooltip("The maximum length for the random Vector2 value.")]
		public FsmFloat maxLength;

		[Tooltip("Context sensitive parameter. Depends on the Shape.")]
		public FsmFloat floatParam1;

		[Tooltip("Context sensitive parameter. Depends on the Shape.")]
		public FsmFloat floatParam2;

		[Tooltip("Scale the vector in Y (e.g., to squash a circle into an oval)")]
		public FsmFloat yScale;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Vector2 variable.")]
		public FsmVector2 storeResult;

		private Vector2 v2;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoRandomVector2()
		{
		}
	}
}
