namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends Events based on the sign of a Float (positive or negative).")]
	[ActionCategory(ActionCategory.Logic)]
	public class FloatSignTest : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to test.")]
		public FsmFloat floatValue;

		[Tooltip("Event to send if the float variable is positive.")]
		public FsmEvent isPositive;

		[Tooltip("Event to send if the float variable is negative.")]
		public FsmEvent isNegative;

		[Tooltip("Repeat every frame. Useful if you want to wait until a float is positive/negative.")]
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

		private void DoSignTest()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
