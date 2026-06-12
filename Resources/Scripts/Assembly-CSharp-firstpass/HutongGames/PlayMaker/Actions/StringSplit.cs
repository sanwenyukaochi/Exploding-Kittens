namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Splits a string into substrings using separator characters.")]
	public class StringSplit : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("String to split.")]
		public FsmString stringToSplit;

		[Tooltip("Characters used to split the string.\nUse '\\n' for newline\nUse '\\t' for tab")]
		public FsmString separators;

		[Tooltip("Remove all leading and trailing white-space characters from each separated string.")]
		public FsmBool trimStrings;

		[Tooltip("Optional characters used to trim each separated string.")]
		public FsmString trimChars;

		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.String, null, 0, 0, 65536)]
		[Tooltip("Store the split strings in a String Array.")]
		public FsmArray stringArray;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
