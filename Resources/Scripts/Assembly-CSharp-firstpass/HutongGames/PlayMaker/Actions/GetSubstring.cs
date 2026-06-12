namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets a sub-string from a String Variable.")]
	public class GetSubstring : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The string to get characters from.")]
		public FsmString stringVariable;

		[RequiredField]
		[Tooltip("The start of the substring (0 = first character).")]
		public FsmInt startIndex;

		[RequiredField]
		[Tooltip("The number of characters to get.")]
		public FsmInt length;

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

		private void DoGetSubstring()
		{
		}
	}
}
