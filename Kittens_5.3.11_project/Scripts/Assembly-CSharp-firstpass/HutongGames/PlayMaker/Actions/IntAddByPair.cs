namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a value to an Integer Variable in pair.")]
	[ActionCategory("Ngui Actions")]
	public class IntAddByPair : FsmStateAction
	{
		[RequiredField]
		[CompoundArray("How Many", "INT Variable", "Add")]
		[UIHint(UIHint.Variable)]
		public FsmInt[] intVariable;

		[RequiredField]
		public FsmInt[] add;

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

		private void doAddInt()
		{
		}
	}
}
