using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("The position of the pivot of this RectTransform relative to the anchor reference point.The anchor reference point is where the anchors are. If the anchor are not together, the four anchor positions are interpolated according to the pivot normalized values.")]
	[ActionCategory("RectTransform")]
	public class RectTransformSetAnchoredPosition : BaseUpdateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Vector2 position. Set to none for no effect, and/or set individual axis below. ")]
		public FsmVector2 position;

		[Tooltip("Setting only the x value. Overrides position x value if set. Set to none for no effect")]
		public FsmFloat x;

		[Tooltip("Setting only the y value. Overrides position x value if set. Set to none for no effect")]
		public FsmFloat y;

		private RectTransform _rt;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void DoSetAnchoredPosition()
		{
		}
	}
}
