namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the sender of the last event.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetEventSentBy : FsmStateAction
	{
		[Tooltip("Store the GameObject that sent the event.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject sentByGameObject;

		[Tooltip("Store the name of the GameObject that sent the event.")]
		[UIHint(UIHint.Variable)]
		public FsmString gameObjectName;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the name of the FSM that sent the event.")]
		public FsmString fsmName;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
