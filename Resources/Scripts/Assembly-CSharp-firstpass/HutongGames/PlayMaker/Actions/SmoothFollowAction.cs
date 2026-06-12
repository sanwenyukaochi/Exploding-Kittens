using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Action version of Unity's Smooth Follow script.")]
	public class SmoothFollowAction : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The game object to control. E.g. The camera.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The GameObject to follow.")]
		public FsmGameObject targetObject;

		[RequiredField]
		[Tooltip("The distance in the x-z plane to the target.")]
		public FsmFloat distance;

		[RequiredField]
		[Tooltip("The height we want the camera to be above the target")]
		public FsmFloat height;

		[Tooltip("How much to dampen height movement.")]
		[RequiredField]
		public FsmFloat heightDamping;

		[RequiredField]
		[Tooltip("How much to dampen rotation changes.")]
		public FsmFloat rotationDamping;

		private GameObject cachedObject;

		private Transform myTransform;

		private GameObject cachedTarget;

		private Transform targetTransform;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnLateUpdate()
		{
		}
	}
}
