namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Normalizes a Vector2 Variable.")]
	[ActionCategory(ActionCategory.Vector2)]
	public class Vector2Normalize : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector to normalize")]
		[RequiredField]
		public FsmVector2 vector2Variable;

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
