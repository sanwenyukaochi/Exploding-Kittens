namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Remove an item from an array.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayRemove : FsmStateAction
	{
		[Tooltip("The Array Variable to use.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmArray array;

		[MatchElementType("array")]
		[Tooltip("Item to remove.")]
		[RequiredField]
		public FsmVar value;

		[Tooltip("Remove all instances of the value. Otherwise removes only the first instance.")]
		public FsmBool allMatches;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoRemoveValue()
		{
		}
	}
}
