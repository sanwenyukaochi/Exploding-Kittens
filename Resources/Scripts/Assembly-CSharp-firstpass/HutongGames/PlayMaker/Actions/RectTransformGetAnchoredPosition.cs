using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the position of the pivot of this RectTransform relative to the anchor reference point.")]
	[ActionCategory("RectTransform")]
	public class RectTransformGetAnchoredPosition : BaseUpdateAction
	{
		[RequiredField]
		[Tooltip("The GameObject target.")]
		[CheckForComponent(typeof(RectTransform))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The anchored Position")]
		public FsmVector2 position;

		[UIHint(UIHint.Variable)]
		[Tooltip("The x component of the anchored Position")]
		public FsmFloat x;

		[Tooltip("The y component of the anchored Position")]
		[UIHint(UIHint.Variable)]
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
