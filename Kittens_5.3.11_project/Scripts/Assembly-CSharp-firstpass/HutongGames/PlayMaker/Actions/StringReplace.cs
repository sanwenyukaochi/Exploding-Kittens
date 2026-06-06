namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Replace a substring with a new String.")]
	public class StringReplace : FsmStateAction
	{
		[Tooltip("The String Variable to examine.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		[Tooltip("Replace this string...")]
		public FsmString replace;

		[Tooltip("... with this string.")]
		public FsmString with;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a string variable.")]
		public FsmString storeResult;

		[Tooltip("Repeat every frame.")]
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

		private void DoReplace()
		{
		}
	}
}
