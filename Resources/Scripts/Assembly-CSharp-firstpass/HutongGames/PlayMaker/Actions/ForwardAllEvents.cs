namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Forwards all event received by this FSM to another target. Optionally specify a list of events to ignore.")]
	public class ForwardAllEvents : FsmStateAction
	{
		[Tooltip("Forward to this target.")]
		public FsmEventTarget forwardTo;

		[Tooltip("Don't forward these events.")]
		public FsmEvent[] exceptThese;

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
