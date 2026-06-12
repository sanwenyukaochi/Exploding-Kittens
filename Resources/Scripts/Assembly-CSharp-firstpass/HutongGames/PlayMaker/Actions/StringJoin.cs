namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Join an array of strings into a single string.")]
	public class StringJoin : FsmStateAction
	{
		[ArrayEditor(VariableType.String, null, 0, 0, 65536)]
		[UIHint(UIHint.Variable)]
		[Tooltip("Array of string to join into a single string.")]
		public FsmArray stringArray;

		[Tooltip("Separator to add between each string.")]
		public FsmString separator;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the joined string in string variable.")]
		public FsmString storeResult;

		public override void OnEnter()
		{
		}
	}
}
