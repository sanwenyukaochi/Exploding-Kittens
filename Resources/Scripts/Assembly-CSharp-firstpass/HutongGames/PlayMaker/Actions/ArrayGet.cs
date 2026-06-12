namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Get a value at an index. Index must be between 0 and the number of items -1. First item is index 0.")]
	public class ArrayGet : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Array Variable to use.")]
		[UIHint(UIHint.Variable)]
		public FsmArray array;

		[Tooltip("The index into the array.")]
		public FsmInt index;

		[RequiredField]
		[Tooltip("Store the value in a variable. NOTE: must be of the same type as the array.")]
		[UIHint(UIHint.Variable)]
		[MatchElementType("array")]
		public FsmVar storeValue;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		[ActionSection("Events")]
		[Tooltip("The event to trigger if the index is out of range.")]
		public FsmEvent indexOutOfRange;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
