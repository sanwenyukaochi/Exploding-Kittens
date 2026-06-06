namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if 2 Array Variables have the same values.")]
	public class ArrayCompare : FsmStateAction
	{
		[Tooltip("The first Array Variable to test.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmArray array1;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The second Array Variable to test.")]
		public FsmArray array2;

		[Tooltip("Event to send if the 2 arrays have the same values.")]
		public FsmEvent SequenceEqual;

		[Tooltip("Event to send if the 2 arrays have different values.")]
		public FsmEvent SequenceNotEqual;

		[Tooltip("Store the result in a Bool variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSequenceEqual()
		{
		}

		private bool TestSequenceEqual(object[] _array1, object[] _array2)
		{
			return false;
		}
	}
}
