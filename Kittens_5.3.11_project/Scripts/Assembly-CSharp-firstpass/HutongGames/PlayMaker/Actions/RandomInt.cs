namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets an Integer Variable to a random value between Min/Max.")]
	public class RandomInt : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Minimum value for the random number.")]
		public FsmInt min;

		[RequiredField]
		[Tooltip("Maximum value for the random number.")]
		public FsmInt max;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in an Integer variable.")]
		public FsmInt storeResult;

		[Tooltip("Should the Max value be included in the possible results?")]
		public bool inclusiveMax;

		[Tooltip("Don't repeat the same value twice.")]
		public FsmBool noRepeat;

		private int randomIndex;

		private int lastIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void PickRandom()
		{
		}
	}
}
