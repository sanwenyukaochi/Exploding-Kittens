namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a Float Variable to a random value between Min/Max.")]
	[ActionCategory(ActionCategory.Math)]
	public class RandomFloat : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Minimum value for the random number.")]
		public FsmFloat min;

		[RequiredField]
		[Tooltip("Maximum value for the random number.")]
		public FsmFloat max;

		[Tooltip("Store the result in a Float variable.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
