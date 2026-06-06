namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the number of Game Objects in the scene with the specified Tag.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetTagCount : FsmStateAction
	{
		[UIHint(UIHint.Tag)]
		[Tooltip("The Tag to search for.")]
		public FsmString tag;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the number found in an int variable.")]
		[RequiredField]
		public FsmInt storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
