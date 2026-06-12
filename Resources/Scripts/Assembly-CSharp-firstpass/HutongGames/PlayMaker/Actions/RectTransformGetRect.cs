using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("The calculated rectangle in the local space of the Transform.")]
	[ActionCategory("RectTransform")]
	public class RectTransformGetRect : BaseUpdateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Rect in a Rect variable.")]
		public FsmRect rect;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the x coordinate in a float variable.")]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the y\u00a0coordinate in a float variable.")]
		public FsmFloat y;

		[Tooltip("Store the width in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat width;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the height in a float variable.")]
		public FsmFloat height;

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
