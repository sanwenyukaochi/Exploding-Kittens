namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Sets the XY channels of a Vector2 Variable. To leave any channel unchanged, set variable to 'None'.")]
	public class SetVector2XY : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector2 target")]
		public FsmVector2 vector2Variable;

		[Tooltip("The vector2 source")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Value;

		[Tooltip("The x component. Override vector2Value if set")]
		public FsmFloat x;

		[Tooltip("The y component.Override vector2Value if set")]
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

		private void DoSetVector2XYZ()
		{
		}
	}
}
