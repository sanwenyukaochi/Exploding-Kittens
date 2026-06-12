namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Adds a String to the end of a String.")]
	public class StringAppend : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Strings to add to.")]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		[Tooltip("String to append")]
		public FsmString appendString;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
