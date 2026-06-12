namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Subtract a value to an Integer Variable in pair.")]
	public class IntSubtractByPair : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[CompoundArray("How Many", "INT Variable", "Subtract")]
		public FsmInt[] intVariable;

		[RequiredField]
		public FsmInt[] Subtract;

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

		private void doSubtractInt()
		{
		}
	}
}
