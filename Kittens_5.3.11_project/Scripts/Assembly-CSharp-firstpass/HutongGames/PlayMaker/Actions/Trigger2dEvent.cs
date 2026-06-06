using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Detect 2D trigger collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components. NOTE: The system events, TRIGGER ENTER 2D, TRIGGER STAY 2D, and TRIGGER EXIT 2D are sent automatically on collisions triggers with any object. Use this action to filter collision triggers by Tag.")]
	public class Trigger2dEvent : FsmStateAction
	{
		[Tooltip("The GameObject to detect collisions on.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The type of trigger event to detect.")]
		public Trigger2DType trigger;

		[UIHint(UIHint.TagMenu)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		[Tooltip("Event to send if the trigger event is detected.")]
		public FsmEvent sendEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

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

		private void StoreCollisionInfo(Collider2D collisionInfo)
		{
		}

		public override void DoTriggerEnter2D(Collider2D other)
		{
		}

		public override void DoTriggerStay2D(Collider2D other)
		{
		}

		public override void DoTriggerExit2D(Collider2D other)
		{
		}

		private void TriggerEnter2D(Collider2D other)
		{
		}

		private void TriggerStay2D(Collider2D other)
		{
		}

		private void TriggerExit2D(Collider2D other)
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
