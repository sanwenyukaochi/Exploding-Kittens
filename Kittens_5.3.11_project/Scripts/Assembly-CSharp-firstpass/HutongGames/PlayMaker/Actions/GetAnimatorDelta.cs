using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the avatar delta position and rotation for the last evaluated frame.")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorDelta : FsmStateActionAnimatorBase
	{
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The avatar delta position for the last evaluated frame")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 deltaPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar delta position for the last evaluated frame")]
		public FsmQuaternion deltaRotation;

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

		private void DoGetDeltaPosition()
		{
		}
	}
}
