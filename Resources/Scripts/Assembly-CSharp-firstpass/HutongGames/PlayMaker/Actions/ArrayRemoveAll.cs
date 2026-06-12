namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Remove all items from an Array.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayRemoveAll : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to remove all items from.")]
		public FsmArray array;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
