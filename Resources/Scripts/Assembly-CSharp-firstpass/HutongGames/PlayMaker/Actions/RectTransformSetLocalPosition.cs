using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Set the local position of this RectTransform.")]
	public class RectTransformSetLocalPosition : BaseUpdateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The position. Set to none for no effect")]
		public FsmVector2 position2d;

		[Tooltip("Or the 3d position. Set to none for no effect")]
		public FsmVector3 position;

		[Tooltip("The x component of the rotation. Set to none for no effect")]
		public FsmFloat x;

		[Tooltip("The y component of the rotation. Set to none for no effect")]
		public FsmFloat y;

		[Tooltip("The z component of the rotation. Set to none for no effect")]
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

		private void DoSetValues()
		{
		}
	}
}
