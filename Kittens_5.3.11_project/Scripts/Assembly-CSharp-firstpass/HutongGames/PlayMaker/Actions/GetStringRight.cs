namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets the Right n characters from a String.")]
	public class GetStringRight : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The string to get characters from.")]
		public FsmString stringVariable;

		[Tooltip("Number of characters to get.")]
		public FsmInt charCount;

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

		private void DoGetStringRight()
		{
		}
	}
}
