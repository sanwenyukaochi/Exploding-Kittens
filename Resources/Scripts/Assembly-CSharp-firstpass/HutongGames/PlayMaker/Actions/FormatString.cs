namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Replaces each format item in a specified string with the text equivalent of variable's value. Stores the result in a string variable.\nSee C# <a href=\"http://msdn.microsoft.com/en-us/library/system.string.format(v=vs.90).aspx\" rel=\"nofollow\">string.Format documentation</a> for usage.")]
	[ActionCategory(ActionCategory.String)]
	public class FormatString : FsmStateAction
	{
		[Tooltip("E.g. Hello {0} and {1}\nWith 2 variables that replace {0} and {1}\nSee C# string.Format docs.")]
		[RequiredField]
		public FsmString format;

		[Tooltip("Variables to use for each formatting item.")]
		public FsmVar[] variables;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the formatted result in a string variable.")]
		public FsmString storeResult;

		[Tooltip("Repeat every frame. Useful if the variables are changing.")]
		public bool everyFrame;

		private object[] objectArray;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoFormatString()
		{
		}
	}
}
