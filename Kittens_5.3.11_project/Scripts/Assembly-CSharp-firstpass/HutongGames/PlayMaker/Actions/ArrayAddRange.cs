namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Add multiple items to the end of an array.\nNOTE: There is a bug in this action when resizing Variables. It will be fixed in the next update.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayAddRange : FsmStateAction
	{
		[Tooltip("The Array Variable to use.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmArray array;

		[RequiredField]
		[Tooltip("The items to add to the array.")]
		[MatchElementType("array")]
		public FsmVar[] variables;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoAddRange()
		{
		}
	}
}
