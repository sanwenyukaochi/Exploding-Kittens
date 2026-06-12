namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Reverses the direction of a Vector2 Variable. Same as multiplying by -1.")]
	[ActionCategory(ActionCategory.Vector2)]
	public class Vector2Invert : FsmStateAction
	{
		[Tooltip("The vector to invert")]
		[UIHint(UIHint.Variable)]
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
