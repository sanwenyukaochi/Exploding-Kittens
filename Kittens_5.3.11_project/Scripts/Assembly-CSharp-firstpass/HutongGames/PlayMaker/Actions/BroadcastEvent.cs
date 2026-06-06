using System;

namespace HutongGames.PlayMaker.Actions
{
	[Obsolete("This action is obsolete; use Send Event with Event Target instead.")]
	[Tooltip("Sends an Event to all FSMs in the scene or to all FSMs on a Game Object. NOTE: This action won't work on the very first frame of the game...")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class BroadcastEvent : FsmStateAction
	{
		[Tooltip("The event to broadcast.")]
		[RequiredField]
		public FsmString broadcastEvent;

		[Tooltip("By default, the event is broadcast to all FSMs in the scene. Optionally you can specify a game object to target. The event will then be broadcast to all FSMs on that game object.")]
		public FsmGameObject gameObject;

		[Tooltip("Broadcast the event to all the Game Object's children too.")]
		public FsmBool sendToChildren;

		[Tooltip("Don't send the event to self.")]
		public FsmBool excludeSelf;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
