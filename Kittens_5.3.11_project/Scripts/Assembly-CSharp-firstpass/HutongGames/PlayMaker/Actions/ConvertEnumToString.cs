namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Converts an Enum value to a String value.")]
	public class ConvertEnumToString : FsmStateAction
	{
		[Tooltip("The Enum variable to convert.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmEnum enumVariable;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The String variable to store the converted value.")]
		public FsmString stringVariable;

		[Tooltip("Repeat every frame. Useful if the Enum variable is changing.")]
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

		private void DoConvertEnumToString()
		{
		}
	}
}
