using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Get the size of this RectTransform relative to the distances between the anchors. this is the 'Width' and 'Height' values in the RectTransform inspector.")]
	public class RectTransformGetSizeDelta : BaseUpdateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The sizeDelta")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 sizeDelta;

		[Tooltip("The x component of the sizeDelta, the width.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat width;

		[UIHint(UIHint.Variable)]
		[Tooltip("The y component of the sizeDelta, the height")]
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
