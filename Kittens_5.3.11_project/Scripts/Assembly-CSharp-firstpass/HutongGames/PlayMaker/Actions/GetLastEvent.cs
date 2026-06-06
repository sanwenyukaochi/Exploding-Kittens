namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets the event that caused the transition to the current state, and stores it in a String Variable.")]
	public class GetLastEvent : FsmStateAction
	{
		[Tooltip("Store the name of the last event in a String Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmString storeEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
