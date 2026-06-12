namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compares 2 Enum values and sends Events based on the result.")]
	public class EnumCompare : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The first Enum Variable.")]
		public FsmEnum enumVariable;

		[Tooltip("The second Enum Variable.")]
		[MatchFieldType("enumVariable")]
		public FsmEnum compareTo;

		[Tooltip("Event to send if the values are equal.")]
		public FsmEvent equalEvent;

		[Tooltip("Event to send if the values are not equal.")]
		public FsmEvent notEqualEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the true/false result in a bool variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame. Useful if the enum is changing over time.")]
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

		private void DoEnumCompare()
		{
		}
	}
}
