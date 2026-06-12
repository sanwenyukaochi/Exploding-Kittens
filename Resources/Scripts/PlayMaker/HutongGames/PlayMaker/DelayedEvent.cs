namespace HutongGames.PlayMaker
{
	public class DelayedEvent
	{
		private readonly Fsm fsm;

		private readonly FsmEvent fsmEvent;

		private readonly FsmEventTarget eventTarget;

		private FsmEventData eventData;

		private float timer;

		private float delay;

		private bool eventFired;

		public FsmEvent FsmEvent => null;

		public float Timer => 0f;

		public bool Finished => false;

		public DelayedEvent(Fsm fsm, FsmEvent fsmEvent, float delay)
		{
		}

		public DelayedEvent(Fsm fsm, string fsmEventName, float delay)
		{
		}

		public DelayedEvent(Fsm fsm, FsmEventTarget eventTarget, FsmEvent fsmEvent, float delay)
		{
		}

		public DelayedEvent(Fsm fsm, FsmEventTarget eventTarget, string fsmEvent, float delay)
		{
		}

		public DelayedEvent(PlayMakerFSM fsm, FsmEvent fsmEvent, float delay)
		{
		}

		public DelayedEvent(PlayMakerFSM fsm, string fsmEventName, float delay)
		{
		}

		public void Update()
		{
		}

		public float GetProgress()
		{
			return 0f;
		}

		public static bool WasSent(DelayedEvent delayedEvent)
		{
			return false;
		}
	}
}
