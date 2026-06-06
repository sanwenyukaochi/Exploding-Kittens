using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sends the specified event when the owner collides with a tagged object. Optionally store the collider and collision force in variables for later use. NOTE: Collisions are processed after other actions, so this action should be ordered last in the action list.")]
	public class CollisionEvent : FsmStateAction
	{
		[Tooltip("The GameObject to detect collisions on. Unlike regular MonoBehaviour scripts, PlayMaker lets you easily detect collisions on other objects. This lets you organize your behaviours the way you want.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The type of collision to detect.")]
		public CollisionType collision;

		[UIHint(UIHint.TagMenu)]
		[Tooltip("Tags to collide with.")]
		public FsmString collideTag;

		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Game Object collided with in a {{Game Object Variable}}.")]
		public FsmGameObject storeCollider;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the force of the collision. NOTE: Use Get Collision Info to get more info about the collision.")]
		public FsmFloat storeForce;

		private PlayMakerProxyBase cachedProxy;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void UpdateCallback()
		{
		}

		private void GetProxyComponent()
		{
		}

		private void AddCallback()
		{
		}

		private void RemoveCallback()
		{
		}

		private void StoreCollisionInfo(Collision collisionInfo)
		{
		}

		public override void DoCollisionEnter(Collision collisionInfo)
		{
		}

		public override void DoCollisionStay(Collision collisionInfo)
		{
		}

		public override void DoCollisionExit(Collision collisionInfo)
		{
		}

		public override void DoControllerColliderHit(ControllerColliderHit collisionInfo)
		{
		}

		public override void DoParticleCollision(GameObject other)
		{
		}

		private void CollisionEnter(Collision collisionInfo)
		{
		}

		private void CollisionStay(Collision collisionInfo)
		{
		}

		private void CollisionExit(Collision collisionInfo)
		{
		}

		private void ControllerColliderHit(ControllerColliderHit collisionInfo)
		{
		}

		private void ParticleCollision(GameObject other)
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
