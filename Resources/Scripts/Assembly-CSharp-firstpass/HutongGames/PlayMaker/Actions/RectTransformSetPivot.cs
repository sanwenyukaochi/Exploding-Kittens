using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("The normalized position in this RectTransform that it rotates around.")]
	[ActionCategory("RectTransform")]
	public class RectTransformSetPivot : BaseUpdateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Vector2 pivot. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 pivot;

		[Tooltip("Setting only the x value. Overrides pivot x value if set. Set to none for no effect")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat x;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overrides pivot y value if set. Set to none for no effect")]
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

		private void DoSetPivotPosition()
		{
		}
	}
}
