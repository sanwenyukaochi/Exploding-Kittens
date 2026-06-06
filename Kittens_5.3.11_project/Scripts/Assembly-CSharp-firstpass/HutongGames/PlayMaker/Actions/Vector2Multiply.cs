namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Multiplies a Vector2 variable by a Float.")]
	public class Vector2Multiply : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector to Multiply")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[RequiredField]
		[Tooltip("The multiplication factor")]
		public FsmFloat multiplyBy;

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
	}
}
