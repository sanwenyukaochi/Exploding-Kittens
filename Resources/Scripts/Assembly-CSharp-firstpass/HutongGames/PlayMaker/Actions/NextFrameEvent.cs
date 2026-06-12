namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event in the next frame. Useful if you want to loop states every frame.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class NextFrameEvent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Event to send.")]
		public FsmEvent sendEvent;

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
