namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts a Bool value to a String value.")]
	public class ConvertBoolToString : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Bool variable to convert.")]
		[UIHint(UIHint.Variable)]
		public FsmBool boolVariable;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The String variable to set based on the Bool variable value.")]
		public FsmString stringVariable;

		[Tooltip("String value if Bool variable is false.")]
		public FsmString falseString;

		[Tooltip("String value if Bool variable is true.")]
		public FsmString trueString;

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

		private void DoConvertBoolToString()
		{
		}
	}
}
