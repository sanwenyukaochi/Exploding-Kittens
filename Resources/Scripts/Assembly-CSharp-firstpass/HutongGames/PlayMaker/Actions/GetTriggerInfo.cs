namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets info on the last trigger event. Typically used after a TRIGGER ENTER, TRIGGER STAY, or TRIGGER EXIT system event or a {{Trigger Event}} action. The owner of the FSM must have a trigger collider.")]
	[ActionCategory(ActionCategory.Physics)]
	public class GetTriggerInfo : FsmStateAction
	{
		[Tooltip("The game object that collided with the owner's trigger.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject gameObjectHit;

		[UIHint(UIHint.Variable)]
		[Tooltip("Useful for triggering different effects. Audio, particles...")]
		public FsmString physicsMaterialName;

		public override void Reset()
		{
		}

		private void StoreTriggerInfo()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
