using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("RectTransform")]
	[Tooltip("Gets the local rotation of this RectTransform.")]
	public class RectTransformGetLocalRotation : BaseUpdateAction
	{
		[RequiredField]
		[Tooltip("The GameObject target.")]
		[CheckForComponent(typeof(RectTransform))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The rotation")]
		public FsmVector3 rotation;

		[Tooltip("The x component of the rotation")]
		public FsmFloat x;

		[Tooltip("The y component of the rotation")]
		public FsmFloat y;

		[Tooltip("The z component of the rotation")]
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
