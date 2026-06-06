namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Each time this action is called it gets the next item from a Array. This lets you quickly loop through all the items of an array to perform actions on them.")]
	public class ArrayGetNext : FsmStateAction
	{
		[Tooltip("The Array Variable to use.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmArray array;

		[Tooltip("From where to start iteration, leave as 0 to start from the beginning")]
		public FsmInt startIndex;

		[Tooltip("When to end iteration, leave as 0 to iterate until the end")]
		public FsmInt endIndex;

		[Tooltip("Event to send to get the next item.")]
		public FsmEvent loopEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("If you want to reset the iteration, raise this flag to true when you enter the state, it will indicate you want to start from the beginning again")]
		public FsmBool resetFlag;

		[Tooltip("Event to send when there are no more items.")]
		public FsmEvent finishedEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the current array item in a variable of the same type.")]
		[ActionSection("Result")]
		[MatchElementType("array")]
		public FsmVar result;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the current array index in an int variable.")]
		public FsmInt currentIndex;

		private int nextItemIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetNextItem()
		{
		}
	}
}
