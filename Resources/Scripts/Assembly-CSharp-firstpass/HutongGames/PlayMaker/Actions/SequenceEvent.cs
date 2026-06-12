namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends the next event on the state each time the state is entered.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SequenceEvent : FsmStateAction
	{
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Delay before sending the event in seconds.")]
		public FsmFloat delay;

		[UIHint(UIHint.Variable)]
		[Tooltip("Assign a variable to control reset. Set it to True to reset the sequence. Value is set to False after resetting.")]
		public FsmBool reset;

		private DelayedEvent delayedEvent;

		private int eventIndex;

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
