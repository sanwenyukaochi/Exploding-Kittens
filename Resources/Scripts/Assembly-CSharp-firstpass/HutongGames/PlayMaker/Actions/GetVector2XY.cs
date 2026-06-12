namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Get the XY channels of a Vector2 Variable and store them in Float Variables.")]
	public class GetVector2XY : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector2 source")]
		public FsmVector2 vector2Variable;

		[Tooltip("The x component")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		[Tooltip("The y component")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

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

		private void DoGetVector2XYZ()
		{
		}
	}
}
