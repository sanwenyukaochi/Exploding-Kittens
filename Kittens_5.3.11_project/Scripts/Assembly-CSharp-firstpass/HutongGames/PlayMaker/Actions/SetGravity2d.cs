namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the gravity vector, or individual axis.")]
	public class SetGravity2d : FsmStateAction
	{
		[Tooltip("Gravity as Vector2.")]
		public FsmVector2 vector;

		[Tooltip("Override the x value of the gravity")]
		public FsmFloat x;

		[Tooltip("Override the y value of the gravity")]
		public FsmFloat y;

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

		private void DoSetGravity()
		{
		}
	}
}
