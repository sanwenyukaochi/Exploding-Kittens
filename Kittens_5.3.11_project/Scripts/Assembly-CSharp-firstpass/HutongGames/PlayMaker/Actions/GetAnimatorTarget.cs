using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the position and rotation of the target specified by SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)).\nThe position and rotation are only valid when a frame has being evaluated after the SetTarget call")]
	public class GetAnimatorTarget : FsmStateActionAnimatorBase
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The target position")]
		[ActionSection("Results")]
		public FsmVector3 targetPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("The target rotation")]
		public FsmQuaternion targetRotation;

		[Tooltip("If set, apply the position and rotation to this gameObject")]
		public FsmGameObject targetGameObject;

		private GameObject cachedTargetGameObject;

		private Transform _transform;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void DoGetTarget()
		{
		}
	}
}
