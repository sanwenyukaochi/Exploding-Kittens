namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Int data from the last Event.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetEventIntData : FsmStateAction
	{
		[Tooltip("Store the int data in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmInt getIntData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
