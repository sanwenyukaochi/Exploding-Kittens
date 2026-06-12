using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("\tThe offset of the upper right corner of the rectangle relative to the upper right anchor.")]
	public class RectTransformSetOffsetMax : BaseUpdateAction
	{
		[Tooltip("The GameObject target.")]
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Vector2 offsetMax. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 offsetMax;

		[Tooltip("Setting only the x value. Overrides offsetMax x value if set. Set to none for no effect")]
		public FsmFloat x;

		[Tooltip("Setting only the y value. Overrides offsetMax y value if set. Set to none for no effect")]
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

		private void DoSetOffsetMax()
		{
		}
	}
}
