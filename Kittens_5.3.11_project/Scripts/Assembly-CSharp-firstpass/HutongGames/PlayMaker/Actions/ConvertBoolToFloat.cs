namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Converts a Bool value to a Float value.")]
	[ActionCategory(ActionCategory.Convert)]
	public class ConvertBoolToFloat : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to convert.")]
		public FsmBool boolVariable;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to set based on the Bool variable value.")]
		public FsmFloat floatVariable;

		[Tooltip("Float value if Bool variable is false.")]
		public FsmFloat falseValue;

		[Tooltip("Float value if Bool variable is true.")]
		public FsmFloat trueValue;

		[Tooltip("Repeat every frame. Useful if the Bool variable is changing.")]
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

		private void DoConvertBoolToFloat()
		{
		}
	}
}
