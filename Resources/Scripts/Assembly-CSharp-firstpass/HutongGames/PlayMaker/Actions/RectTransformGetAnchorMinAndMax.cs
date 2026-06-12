using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("The normalized position in the parent RectTransform that the upper right corner is anchored to. This is relative screen space, values ranges from 0 to 1")]
	public class RectTransformGetAnchorMinAndMax : BaseUpdateAction
	{
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Vector2 anchor max. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 anchorMax;

		[Tooltip("The Vector2 anchor min. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 anchorMin;

		[Tooltip("Setting only the x value. Overrides anchorMax x value if set. Set to none for no effect")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat xMax;

		[Tooltip("Setting only the x value. Overrides anchorMax x value if set. Set to none for no effect")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat yMax;

		[Tooltip("Setting only the x value. Overrides anchorMin x value if set. Set to none for no effect")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat xMin;

		[Tooltip("Setting only the x value. Overrides anchorMin x value if set. Set to none for no effect")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat yMin;

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

		private void DoGetValues()
		{
		}
	}
}
