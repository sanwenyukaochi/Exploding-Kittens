namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Block events while this action is active.")]
	public class BlockEvents : FsmStateAction
	{
		public enum Options
		{
			Timeout = 0,
			WhileTrue = 1,
			WhileFalse = 2,
			UntilTrue = 3,
			UntilFalse = 4,
			UntilEvent = 5
		}

		[Tooltip("When to block events.")]
		public Options condition;

		[Tooltip("Context sensitive parameter. Depends on Condition.")]
		public FsmFloat floatParam;

		[Tooltip("Context sensitive parameter. Depends on Condition.")]
		public FsmBool boolParam;

		[Tooltip("Context sensitive parameter. Depends on Condition.")]
		[EventNotSent]
		public FsmEvent eventParam;

		[Tooltip("Log any events blocked by this action. Helpful for debugging.")]
		[ActionSection("Debug")]
		public FsmBool logBlockedEvents;

		private bool firstTime;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void OnUpdate()
		{
		}

		public override bool Event(FsmEvent fsmEvent)
		{
			return false;
		}

		private bool Validate()
		{
			return false;
		}

		private bool DoBlockEvent(FsmEvent fsmEvent)
		{
			return false;
		}
	}
}
