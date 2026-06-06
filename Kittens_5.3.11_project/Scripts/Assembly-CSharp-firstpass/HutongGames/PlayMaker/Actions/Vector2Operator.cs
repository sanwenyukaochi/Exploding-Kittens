namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Performs most possible operations on 2 Vector2: Dot product, Distance, Angle, Add, Subtract, Multiply, Divide, Min, Max")]
	[ActionCategory(ActionCategory.Vector2)]
	public class Vector2Operator : FsmStateAction
	{
		public enum Vector2Operation
		{
			DotProduct = 0,
			Distance = 1,
			Angle = 2,
			Add = 3,
			Subtract = 4,
			Multiply = 5,
			Divide = 6,
			Min = 7,
			Max = 8
		}

		[RequiredField]
		[Tooltip("The first vector")]
		public FsmVector2 vector1;

		[RequiredField]
		[Tooltip("The second vector")]
		public FsmVector2 vector2;

		[Tooltip("The operation")]
		public Vector2Operation operation;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector2 result when it applies.")]
		public FsmVector2 storeVector2Result;

		[UIHint(UIHint.Variable)]
		[Tooltip("The float result when it applies")]
		public FsmFloat storeFloatResult;

		[Tooltip("Repeat every frame")]
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

		private void DoVector2Operator()
		{
		}
	}
}
