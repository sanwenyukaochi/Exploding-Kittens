namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Gets info on the last Character Controller collision event. The owner of the FSM must have a character controller. Typically this action is used after a CONTROLLER COLLIDER HIT system event.")]
	public class GetControllerHitInfo : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject hit in the last collision.")]
		public FsmGameObject gameObjectHit;

		[Tooltip("Store the contact point of the last collision in world coordinates.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 contactPoint;

		[Tooltip("Store the normal of the last collision.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 contactNormal;

		[Tooltip("Store the direction of the last move before the collision.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 moveDirection;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance of the last move before the collision.")]
		public FsmFloat moveLength;

		[Tooltip("Store the physics material of the Game Object Hit. Useful for triggering different effects. Audio, particles...")]
		[UIHint(UIHint.Variable)]
		public FsmString physicsMaterialName;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		private void StoreTriggerInfo()
		{
		}

		public override void OnEnter()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
