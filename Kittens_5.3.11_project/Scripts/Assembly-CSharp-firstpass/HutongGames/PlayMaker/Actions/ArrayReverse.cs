namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Reverse the order of items in an Array.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayReverse : FsmStateAction
	{
		[Tooltip("The Array to reverse.")]
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
