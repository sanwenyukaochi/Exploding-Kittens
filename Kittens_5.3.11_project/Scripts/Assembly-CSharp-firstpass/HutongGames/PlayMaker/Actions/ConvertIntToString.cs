namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Converts an Integer value to a String value with an optional format.")]
	[ActionCategory(ActionCategory.Convert)]
	public class ConvertIntToString : FsmStateAction
	{
		[Tooltip("The Int variable to convert.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("A String variable to store the converted value.")]
		public FsmString stringVariable;

		[Tooltip("Optional Format, allows for leading zeros. E.g., 0000")]
		public FsmString format;

		[Tooltip("Repeat every frame. Useful if the Int variable is changing.")]
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

		private void DoConvertIntToString()
		{
		}
	}
}
