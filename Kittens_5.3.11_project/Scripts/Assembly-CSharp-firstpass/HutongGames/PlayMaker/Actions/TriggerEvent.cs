using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sends an event when the owner collides with a tagged trigger (see Unity Tag and Trigger docs). Optionally send an event and store the collider for later use. NOTE: Collisions are processed after other actions, so this action should be ordered last in the list.")]
	public class TriggerEvent : FsmStateAction
	{
		[Tooltip("The GameObject to detect trigger events on.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The type of trigger event to detect.")]
		public TriggerType trigger;

		[UIHint(UIHint.TagMenu)]
		[Tooltip("Only collide with triggers that have this tag.")]
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

		private void StoreCollisionInfo(Collider collisionInfo)
		{
		}

		public override void DoTriggerEnter(Collider other)
		{
		}

		public override void DoTriggerStay(Collider other)
		{
		}

		public override void DoTriggerExit(Collider other)
		{
		}

		private void TriggerEnter(Collider other)
		{
		}

		private void TriggerStay(Collider other)
		{
		}

		private void TriggerExit(Collider other)
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
