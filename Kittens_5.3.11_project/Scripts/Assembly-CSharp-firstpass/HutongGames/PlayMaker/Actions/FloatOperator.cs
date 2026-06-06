namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Performs math operations on 2 Floats: Add, Subtract, Multiply, Divide, Min, Max.")]
	public class FloatOperator : FsmStateAction
	{
		public enum Operation
		{
			Add = 0,
			Subtract = 1,
			Multiply = 2,
			Divide = 3,
			Min = 4,
			Max = 5,
			Modulus = 6
		}

		[RequiredField]
		[Tooltip("The first float.")]
		public FsmFloat float1;

		[Tooltip("The second float.")]
		[RequiredField]
		public FsmFloat float2;

		[Tooltip("The math operation to perform on the floats.")]
		public Operation operation;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of the operation in a float variable.")]
		public FsmFloat storeResult;

		[Tooltip("Repeat every frame. Useful if the variables are changing.")]
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

		private void DoFloatOperator()
		{
		}
	}
}
