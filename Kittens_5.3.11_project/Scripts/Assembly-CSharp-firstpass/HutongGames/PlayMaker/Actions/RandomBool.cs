namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Bool Variable to True or False randomly.")]
	public class RandomBool : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable. Hint: Use a {{Bool Test}} action to branch based on this \"coin toss\"")]
		public FsmBool storeResult;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
