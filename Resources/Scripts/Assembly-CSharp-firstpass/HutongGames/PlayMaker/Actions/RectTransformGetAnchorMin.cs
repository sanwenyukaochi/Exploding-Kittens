using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the normalized position in the parent RectTransform that the lower left corner is anchored to.")]
	[ActionCategory("RectTransform")]
	public class RectTransformGetAnchorMin : BaseUpdateAction
	{
		[Tooltip("The GameObject target.")]
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The anchorMin")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 anchorMin;

		[Tooltip("The x component of the anchorMin")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		[Tooltip("The y component of the anchorMin")]
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
