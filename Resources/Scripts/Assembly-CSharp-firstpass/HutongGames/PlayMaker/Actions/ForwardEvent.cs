namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Forward an event received by this FSM to another target.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class ForwardEvent : FsmStateAction
	{
		[Tooltip("Forward to this target.")]
		public FsmEventTarget forwardTo;

		[Tooltip("The events to forward.")]
		public FsmEvent[] eventsToForward;

		[Tooltip("Should this action eat the events or pass them on.")]
		public bool eatEvents;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override bool Event(FsmEvent fsmEvent)
		{
			return false;
		}
	}
}
