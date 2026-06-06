namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Wraps the value of Int Variable so it stays in a Min/Max range.\n\nExamples:\nWrap 120 between 0 and 100 -> 20\nWrap -10 between 0 and 100 -> 90")]
	[ActionCategory(ActionCategory.Math)]
	public class IntWrap : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Int variable to wrap.")]
		public FsmInt intVariable;

		[RequiredField]
		[Tooltip("The minimum value allowed.")]
		public FsmInt minValue;

		[Tooltip("The maximum value allowed.")]
		[RequiredField]
		public FsmInt maxValue;

		[Tooltip("Repeat every frame. Useful if the int variable is changing.")]
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

		private void DoWrap()
		{
		}
	}
}
