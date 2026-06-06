using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Set the local rotation of this RectTransform.")]
	public class RectTransformSetLocalRotation : BaseUpdateAction
	{
		[Tooltip("The GameObject target.")]
		[CheckForComponent(typeof(RectTransform))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The rotation. Set to none for no effect")]
		public FsmVector3 rotation;

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
