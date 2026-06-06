namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if the value of an integer variable changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	public class IntChanged : FsmStateAction
	{
		[Tooltip("The int variable to test.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		[Tooltip("Event to send if changed.")]
		public FsmEvent changedEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Set to true if changed, otherwise False.")]
		public FsmBool storeResult;

		private int previousValue;

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
