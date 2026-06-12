namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Performs boolean operations on 2 Bool Variables.")]
	public class BoolOperator : FsmStateAction
	{
		public enum Operation
		{
			AND = 0,
			NAND = 1,
			OR = 2,
			XOR = 3
		}

		[Tooltip("The first Bool variable.")]
		[RequiredField]
		public FsmBool bool1;

		[RequiredField]
		[Tooltip("The second Bool variable.")]
		public FsmBool bool2;

		[Tooltip("Boolean Operation.")]
		public Operation operation;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool Variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame while the state is active.")]
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

		private void DoBoolOperator()
		{
		}
	}
}
