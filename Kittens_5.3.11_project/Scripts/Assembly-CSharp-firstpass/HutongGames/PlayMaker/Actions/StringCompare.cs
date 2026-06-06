namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compares 2 Strings and sends Events based on the result.")]
	public class StringCompare : FsmStateAction
	{
		[Tooltip("The String Variable to compare.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		[Tooltip("Compare to this text.")]
		public FsmString compareTo;

		[Tooltip("Event to send if strings are equal.")]
		public FsmEvent equalEvent;

		[Tooltip("Event to send if strings are not equal.")]
		public FsmEvent notEqualEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the true/false result in a bool variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame. Useful if any of the strings are changing over time.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoStringCompare()
		{
		}
	}
}
