namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends a Random State Event after an optional delay. Use this to transition to a random state connected to the current state.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class RandomEvent : FsmStateAction
	{
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Delay before sending the event (seconds).")]
		public FsmFloat delay;

		[Tooltip("Don't repeat the same event twice in a row.")]
		public FsmBool noRepeat;

		private DelayedEvent delayedEvent;

		private int randomEventIndex;

		private int lastEventIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private FsmEvent GetRandomEvent()
		{
			return null;
		}
	}
}
