using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Detect collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components. NOTE: The system events, COLLISION ENTER 2D, COLLISION STAY 2D, and COLLISION EXIT 2D are sent automatically on collisions with any object. Use this action instead to filter collisions by Tag.")]
	public class Collision2dEvent : FsmStateAction
	{
		[Tooltip("The GameObject to detect collisions on.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The type of collision to detect.")]
		public Collision2DType collision;

		[Tooltip("If true, Collision that are not enabled will be ignored.")]
		public FsmBool ignoreDisabled;

		[UIHint(UIHint.TagMenu)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeCollider;

		[Tooltip("Store the force of the collision. NOTE: Use Get Collision 2D Info to get more info about the collision.")]
		[UIHint(UIHint.Variable)]
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

		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
		}

		public override void DoCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		public override void DoCollisionStay2D(Collision2D collisionInfo)
		{
		}

		public override void DoCollisionExit2D(Collision2D collisionInfo)
		{
		}

		public override void DoParticleCollision(GameObject other)
		{
		}

		private void CollisionEnter2D(Collision2D collisionInfo)
		{
		}

		private void CollisionStay2D(Collision2D collisionInfo)
		{
		}

		private void CollisionExit2D(Collision2D collisionInfo)
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
