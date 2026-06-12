using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Get the normalized position in this RectTransform that it rotates around.")]
	public class RectTransformGetPivot : BaseUpdateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The pivot")]
		public FsmVector2 pivot;

		[UIHint(UIHint.Variable)]
		[Tooltip("The x component of the pivot")]
		public FsmFloat x;

		[Tooltip("The y component of the pivot")]
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
