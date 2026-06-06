namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Get a Random item from an Array.")]
	public class ArrayGetRandom : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array to use.")]
		[RequiredField]
		public FsmArray array;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value in a variable.")]
		[MatchElementType("array")]
		public FsmVar storeValue;

		[Tooltip("The index of the value in the array.")]
		[UIHint(UIHint.Variable)]
		public FsmInt index;

		[Tooltip("Don't get the same item twice in a row.")]
		public FsmBool noRepeat;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private int randomIndex;

		private int lastIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetRandomValue()
		{
		}
	}
}
