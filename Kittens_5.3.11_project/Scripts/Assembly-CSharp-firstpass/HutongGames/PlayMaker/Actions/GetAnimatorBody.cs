using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the avatar body mass center position and rotation. Optionally accepts a GameObject to get the body transform. \nThe position and rotation are local to the GameObject")]
	public class GetAnimatorBody : FsmStateActionAnimatorBase
	{
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar body mass center")]
		[ActionSection("Results")]
		public FsmVector3 bodyPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("The avatar body mass center")]
		public FsmQuaternion bodyRotation;

		[Tooltip("If set, apply the body mass center position and rotation to this gameObject")]
		public FsmGameObject bodyGameObject;

		private GameObject cachedBodyGameObject;

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

		private void DoGetBodyPosition()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
