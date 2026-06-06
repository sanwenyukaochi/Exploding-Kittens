namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Converts an String value to an Int value.")]
	[ActionCategory(ActionCategory.Convert)]
	public class ConvertStringToInt : FsmStateAction
	{
		[Tooltip("The String variable to convert to an integer.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmString stringVariable;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in an Int variable.")]
		public FsmInt intVariable;

		[Tooltip("Repeat every frame. Useful if the String variable is changing.")]
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

		private void DoConvertStringToInt()
		{
		}
	}
}
