namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Converts a Float value to a String value with optional format.")]
	[ActionCategory(ActionCategory.Convert)]
	public class ConvertFloatToString : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The float variable to convert.")]
		public FsmFloat floatVariable;

		[Tooltip("A string variable to store the converted value.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmString stringVariable;

		[Tooltip("Optional Format, allows for leading zeros. E.g., 0000")]
		public FsmString format;

		[Tooltip("Repeat every frame. Useful if the float variable is changing.")]
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

		private void DoConvertFloatToString()
		{
		}
	}
}
