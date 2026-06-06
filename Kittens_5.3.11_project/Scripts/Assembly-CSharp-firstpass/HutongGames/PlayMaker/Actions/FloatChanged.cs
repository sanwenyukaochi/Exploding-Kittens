namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if the value of a Float variable changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	[ActionCategory(ActionCategory.Logic)]
	public class FloatChanged : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to watch for a change.")]
		public FsmFloat floatVariable;

		[Tooltip("Event to send if the float variable changes.")]
		public FsmEvent changedEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Set to True if the float variable changes.")]
		public FsmBool storeResult;

		private float previousValue;

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
