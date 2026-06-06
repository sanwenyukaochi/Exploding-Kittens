using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("The normalized position in the parent RectTransform that the lower left corner is anchored to. This is relative screen space, values ranges from 0 to 1")]
	public class RectTransformSetAnchorMin : BaseUpdateAction
	{
		[Tooltip("The GameObject target.")]
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Vector2 anchor. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 anchorMin;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overrides anchorMin x value if set. Set to none for no effect")]
		public FsmFloat x;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overrides anchorMin x value if set. Set to none for no effect")]
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

		private void DoSetAnchorMin()
		{
		}
	}
}
