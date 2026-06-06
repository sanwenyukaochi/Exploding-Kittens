namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Sends an Event in LateUpdate, after the Update loop.")]
	public class LateUpdateEvent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Event to send in LateUpdate.")]
		public FsmEvent sendEvent;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnLateUpdate()
		{
		}
	}
}
