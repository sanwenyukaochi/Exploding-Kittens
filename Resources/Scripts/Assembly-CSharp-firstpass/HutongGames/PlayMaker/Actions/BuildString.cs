namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Builds a String from other Strings.")]
	public class BuildString : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Array of Strings to combine.")]
		public FsmString[] stringParts;

		[Tooltip("Separator to insert between each String. E.g. space character.")]
		public FsmString separator;

		[Tooltip("Add Separator to end of built string.")]
		public FsmBool addToEnd;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the final String in a variable.")]
		public FsmString storeResult;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private string result;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoBuildString()
		{
		}
	}
}
