using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("The position ( normalized or not) in the parent RectTransform keeping the anchor rect size intact. This lets you position the whole Rect in one go. Use this to easily animate movement (like IOS sliding UIView)")]
	public class RectTransformSetAnchorRectPosition : BaseUpdateAction
	{
		public enum AnchorReference
		{
			TopLeft = 0,
			Top = 1,
			TopRight = 2,
			Right = 3,
			BottomRight = 4,
			Bottom = 5,
			BottomLeft = 6,
			Left = 7,
			Center = 8
		}

		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The reference for the given position")]
		public AnchorReference anchorReference;

		[Tooltip("Are the supplied screen coordinates normalized (0-1), or in pixels.")]
		public FsmBool normalized;

		[Tooltip("The Vector2 position, and/or set individual axis below.")]
		public FsmVector2 anchor;

		[Tooltip("Anchor X position.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat x;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Anchor Y position.")]
		public FsmFloat y;

		private RectTransform _rt;

		private Rect _anchorRect;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void DoSetAnchor()
		{
		}
	}
}
