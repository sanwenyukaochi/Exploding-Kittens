namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Insert an item into an Array at the specified index.")]
	public class ArrayInsert : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		[RequiredField]
		public FsmArray array;

		[RequiredField]
		[Tooltip("Item to add.")]
		[MatchElementType("array")]
		public FsmVar value;

		[Tooltip("The index to insert at.\n0 = first, 1 = second...")]
		public FsmInt atIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoInsertValue()
		{
		}
	}
}
