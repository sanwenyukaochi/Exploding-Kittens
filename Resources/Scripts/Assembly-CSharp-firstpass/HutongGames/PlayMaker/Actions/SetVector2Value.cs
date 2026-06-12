namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Sets the value of a Vector2 Variable.")]
	public class SetVector2Value : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The vector2 target")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		[RequiredField]
		[Tooltip("The vector2 source")]
		public FsmVector2 vector2Value;

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
	}
}
