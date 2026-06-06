using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the avatar body mass center position and rotation.Optionally accept a GameObject to get the body transform. \nThe position and rotation are local to the gameobject")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorRoot : FsmStateActionAnimatorBase
	{
		[Tooltip("The target.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The avatar body mass center")]
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 rootPosition;

		[Tooltip("The avatar body mass center")]
		[UIHint(UIHint.Variable)]
		public FsmQuaternion rootRotation;

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
	}
}
