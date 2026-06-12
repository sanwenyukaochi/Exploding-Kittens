namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Bool value to an Integer value.")]
	public class ConvertBoolToInt : FsmStateAction
	{
		[Tooltip("The Bool variable to convert.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool boolVariable;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Integer variable to set based on the Bool variable value.")]
		[RequiredField]
		public FsmInt intVariable;

		[Tooltip("Integer value if Bool variable is false.")]
		public FsmInt falseValue;

		[Tooltip("Integer value if Bool variable is false.")]
		public FsmInt trueValue;

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

		private void DoConvertBoolToInt()
		{
		}
	}
}
