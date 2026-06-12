namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets the Length of a String.")]
	public class GetStringLength : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The string to measure.")]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		[Tooltip("Store the result in an Int Variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

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

		private void DoGetStringLength()
		{
		}
	}
}
