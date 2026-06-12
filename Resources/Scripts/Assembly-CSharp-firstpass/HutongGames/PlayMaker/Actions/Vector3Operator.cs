namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Performs most possible operations on 2 Vector3: Dot product, Cross product, Distance, Angle, Project, Reflect, Add, Subtract, Multiply, Divide, Min, Max")]
	public class Vector3Operator : FsmStateAction
	{
		public enum Vector3Operation
		{
			DotProduct = 0,
			CrossProduct = 1,
			Distance = 2,
			Angle = 3,
			Project = 4,
			Reflect = 5,
			Add = 6,
			Subtract = 7,
			Multiply = 8,
			Divide = 9,
			Min = 10,
			Max = 11
		}

		[RequiredField]
		[Tooltip("The first vector in the operation.")]
		public FsmVector3 vector1;

		[RequiredField]
		[Tooltip("The second vector in the operation.")]
		public FsmVector3 vector2;

		[Tooltip("The operation to perform.")]
		public Vector3Operation operation;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Vector3 Variable.")]
		public FsmVector3 storeVector3Result;

		[Tooltip("Store a float result in a Float Variable (E.g., Dot, Distance, Angle)")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeFloatResult;

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

		private void DoVector3Operator()
		{
		}
	}
}
