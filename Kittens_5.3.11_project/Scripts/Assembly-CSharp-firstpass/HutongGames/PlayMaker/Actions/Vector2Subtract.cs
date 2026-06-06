namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Subtracts a Vector2 value from a Vector2 variable.")]
	public class Vector2Subtract : FsmStateAction
	{
		[Tooltip("The Vector2 operand")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		[RequiredField]
		[Tooltip("The vector2 to subtract with")]
		public FsmVector2 subtractVector;

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
