using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("The offset of the lower left corner of the rectangle relative to the lower left anchor.")]
	[ActionCategory("RectTransform")]
	public class RectTransformSetOffsetMin : BaseUpdateAction
	{
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Vector2 offsetMin. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 offsetMin;

		[Tooltip("Setting only the x value. Overrides offsetMin x value if set. Set to none for no effect")]
		public FsmFloat x;

		[Tooltip("Setting only the x value. Overrides offsetMin y value if set. Set to none for no effect")]
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

		private void DoSetOffsetMin()
		{
		}
	}
}
