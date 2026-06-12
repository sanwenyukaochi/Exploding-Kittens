namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if the value of a Bool Variable has changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	[ActionCategory(ActionCategory.Logic)]
	public class BoolChanged : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to watch for changes.")]
		[RequiredField]
		public FsmBool boolVariable;

		[Tooltip("Event to send if the variable changes.")]
		public FsmEvent changedEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Set to True if changed.")]
		public FsmBool storeResult;

		private bool previousValue;

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
