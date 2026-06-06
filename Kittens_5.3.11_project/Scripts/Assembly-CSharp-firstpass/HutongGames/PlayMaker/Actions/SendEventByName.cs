namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event by name after an optional delay. NOTE: Use this over Send Event if you store events as string variables.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SendEventByName : FsmStateAction
	{
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[RequiredField]
		[Tooltip("The event to send. NOTE: Events must be marked Global to send between FSMs.")]
		public FsmString sendEvent;

		[Tooltip("Optional delay in seconds.")]
		[HasFloatSlider(0f, 10f)]
		public FsmFloat delay;

		[Tooltip("Repeat every frame. Rarely needed, but can be useful when sending events to other FSMs.")]
		public bool everyFrame;

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
