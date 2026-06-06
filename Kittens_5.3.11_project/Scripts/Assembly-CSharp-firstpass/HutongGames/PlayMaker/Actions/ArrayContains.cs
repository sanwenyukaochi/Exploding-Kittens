namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check if an Array contains a value. Optionally get its index.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayContains : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Array Variable to use.")]
		[UIHint(UIHint.Variable)]
		public FsmArray array;

		[Tooltip("The value to check against in the array.")]
		[MatchElementType("array")]
		[RequiredField]
		public FsmVar value;

		[ActionSection("Result")]
		[Tooltip("The index of the value in the array.")]
		[UIHint(UIHint.Variable)]
		public FsmInt index;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store in a bool whether it contains that element or not.")]
		public FsmBool isContained;

		[Tooltip("Event sent if the array contains that element.")]
		public FsmEvent isContainedEvent;

		[Tooltip("Event sent if the array does not contain that element.")]
		public FsmEvent isNotContainedEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoCheckContainsValue()
		{
		}
	}
}
