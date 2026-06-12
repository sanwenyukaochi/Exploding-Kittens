namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Performs math operation on 2 Integers: Add, Subtract, Multiply, Divide, Min, Max.")]
	[ActionCategory(ActionCategory.Math)]
	public class IntOperator : FsmStateAction
	{
		public enum Operation
		{
			Add = 0,
			Subtract = 1,
			Multiply = 2,
			Divide = 3,
			Min = 4,
			Max = 5
		}

		[RequiredField]
		[Tooltip("The first integer.")]
		public FsmInt integer1;

		[RequiredField]
		[Tooltip("The second integer.")]
		public FsmInt integer2;

		[Tooltip("The operation to perform on the 2 integers.")]
		public Operation operation;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in an Integer Variable.")]
		public FsmInt storeResult;

		[Tooltip("Perform this action every frame. Useful if you're using variables that are changing.")]
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

		private void DoIntOperator()
		{
		}
	}
}
