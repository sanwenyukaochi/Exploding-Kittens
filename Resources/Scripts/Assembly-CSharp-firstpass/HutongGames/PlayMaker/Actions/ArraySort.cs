namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Sort items in an Array.")]
	public class ArraySort : FsmStateAction
	{
		[Tooltip("The Array to sort.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmArray array;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
