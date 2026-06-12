using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Get the normalized position in the parent RectTransform that the upper right corner is anchored to.")]
	public class RectTransformGetAnchorMax : BaseUpdateAction
	{
		[Tooltip("The GameObject target.")]
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The anchorMax")]
		public FsmVector2 anchorMax;

		[Tooltip("The x component of the anchorMax")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("The y component of the anchorMax")]
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

		private void DoGetValues()
		{
		}
	}
}
