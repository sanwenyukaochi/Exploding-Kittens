namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the name of the previously active state and stores it in a String Variable.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetPreviousStateName : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the name in a String Variable.")]
		public FsmString storeName;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
