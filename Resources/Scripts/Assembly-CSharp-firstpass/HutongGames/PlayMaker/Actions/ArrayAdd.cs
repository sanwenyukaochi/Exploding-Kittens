namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Add an item to the end of an Array.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayAdd : FsmStateAction
	{
		[Tooltip("The Array Variable to use.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmArray array;

		[RequiredField]
		[Tooltip("Item to add.")]
		[MatchElementType("array")]
		public FsmVar value;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoAddValue()
		{
		}
	}
}
