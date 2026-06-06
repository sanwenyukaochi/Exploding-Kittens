namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Shuffle values in an array. Optionally set a start index and range to shuffle only part of the array.")]
	public class ArrayShuffle : FsmStateAction
	{
		[Tooltip("The Array to shuffle.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmArray array;

		[Tooltip("Optional start Index for the shuffling. Leave it to none or 0 for no effect")]
		public FsmInt startIndex;

		[Tooltip("Optional range for the shuffling, starting at the start index if greater than 0. Leave it to none or 0 for no effect, it will shuffle the whole array")]
		public FsmInt shufflingRange;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
