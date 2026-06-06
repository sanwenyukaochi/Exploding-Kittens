namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Compare 2 Object Variables and send events based on the result.")]
	public class ObjectCompare : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Readonly]
		[Tooltip("The Object Variable to compare.")]
		public FsmObject objectVariable;

		[RequiredField]
		[Tooltip("The value to compare it to.")]
		public FsmObject compareTo;

		[Tooltip("Event to send if the 2 object values are equal.")]
		public FsmEvent equalEvent;

		[Tooltip("Event to send if the 2 object values are not equal.")]
		public FsmEvent notEqualEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame.")]
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

		private void DoObjectCompare()
		{
		}
	}
}
