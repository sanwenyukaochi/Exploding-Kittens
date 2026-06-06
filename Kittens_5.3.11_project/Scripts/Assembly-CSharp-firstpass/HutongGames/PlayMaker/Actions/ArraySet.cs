namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the value at an index. Index must be between 0 and the number of items -1. First item is index 0.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArraySet : FsmStateAction
	{
		[Tooltip("The Array Variable to use.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmArray array;

		[Tooltip("The index into the array.")]
		public FsmInt index;

		[MatchElementType("array")]
		[Tooltip("Set the value of the array at the specified index.")]
		[RequiredField]
		public FsmVar value;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		[ActionSection("Events")]
		[Tooltip("The event to trigger if the index is out of range")]
		public FsmEvent indexOutOfRange;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetValue()
		{
		}
	}
}
