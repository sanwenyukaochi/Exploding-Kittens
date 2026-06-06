namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends a Random Event picked from an array of Events. Optionally set the relative weight of each event.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SendRandomEvent : FsmStateAction
	{
		[Tooltip("A possible Event choice.")]
		[CompoundArray("Events", "Event", "Weight")]
		public FsmEvent[] events;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The relative probability of this Event being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		public FsmFloat[] weights;

		[Tooltip("Optional delay in seconds before sending the event.")]
		public FsmFloat delay;

		private DelayedEvent delayedEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
