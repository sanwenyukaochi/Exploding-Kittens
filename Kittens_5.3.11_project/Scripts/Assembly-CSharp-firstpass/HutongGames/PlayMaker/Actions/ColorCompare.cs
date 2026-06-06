namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the comparison of 2 Colors.")]
	public class ColorCompare : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The first Color.")]
		public FsmColor color1;

		[RequiredField]
		[Tooltip("The second Color.")]
		public FsmColor color2;

		[RequiredField]
		[Tooltip("Tolerance of test, to test for 'almost equals' or to ignore small floating point rounding differences.")]
		public FsmFloat tolerance;

		[Tooltip("Event sent if Color 1 equals Color 2 (within Tolerance)")]
		public FsmEvent equal;

		[Tooltip("Event sent if Color 1 does not equal Color 2 (within Tolerance)")]
		public FsmEvent notEqual;

		[Tooltip("Repeat every frame. Useful if the variables are changing and you're waiting for a particular result.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoCompare()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
