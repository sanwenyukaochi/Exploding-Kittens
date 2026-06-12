namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Converts an Integer value to a Float value.")]
	[ActionCategory(ActionCategory.Convert)]
	public class ConvertIntToFloat : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Integer variable to convert to a float.")]
		public FsmInt intVariable;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Float variable.")]
		public FsmFloat floatVariable;

		[Tooltip("Repeat every frame. Useful if the Integer variable is changing.")]
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

		private void DoConvertIntToFloat()
		{
		}
	}
}
