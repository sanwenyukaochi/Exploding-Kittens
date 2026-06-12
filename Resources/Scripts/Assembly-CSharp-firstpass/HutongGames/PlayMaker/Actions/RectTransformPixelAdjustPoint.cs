using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Convert a given point in screen space into a pixel correct point.")]
	public class RectTransformPixelAdjustPoint : BaseUpdateAction
	{
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[CheckForComponent(typeof(Canvas))]
		[Tooltip("The canvas. Leave to none to use the canvas of the gameObject")]
		public FsmGameObject canvas;

		[Tooltip("The screen position.")]
		public FsmVector2 screenPoint;

		[UIHint(UIHint.Variable)]
		[Tooltip("Pixel adjusted point from the screen position.")]
		[RequiredField]
		[ActionSection("Result")]
		public FsmVector2 pixelPoint;

		private RectTransform _rt;

		private Canvas _canvas;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void DoAction()
		{
		}
	}
}
