using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the Local position of this RectTransform. This is Screen Space values using the anchoring as reference, so 0,0 is the center of the screen if the anchor is te center of the screen.")]
	[ActionCategory("RectTransform")]
	public class RectTransformGetLocalPosition : BaseUpdateAction
	{
		public enum LocalPositionReference
		{
			Anchor = 0,
			CenterPosition = 1
		}

		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Get local position relative to Anchor or Center.")]
		public LocalPositionReference reference;

		[UIHint(UIHint.Variable)]
		[Tooltip("The position")]
		public FsmVector3 position;

		[UIHint(UIHint.Variable)]
		[Tooltip("The position in a Vector 2d ")]
		public FsmVector2 position2d;

		[Tooltip("The x component of the Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("The y component of the Position")]
		public FsmFloat y;

		[Tooltip("The z component of the Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat z;

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
