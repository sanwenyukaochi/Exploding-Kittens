namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Resize an array.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayResize : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The Array Variable to resize")]
		public FsmArray array;

		[Tooltip("The new size of the array.")]
		public FsmInt newSize;

		[Tooltip("The event to trigger if the new size is out of range")]
		public FsmEvent sizeOutOfRangeEvent;

		public override void OnEnter()
		{
		}
	}
}
