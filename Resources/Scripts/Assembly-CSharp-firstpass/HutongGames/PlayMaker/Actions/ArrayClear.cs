namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets all items in an Array to their default value: 0, empty string, false, or null depending on their type. Optionally defines a reset value to use.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayClear : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to clear.")]
		public FsmArray array;

		[MatchElementType("array")]
		[Tooltip("Optional reset value. Leave as None for default value.")]
		public FsmVar resetValue;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
