namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Snap a Vector2 to an angle increment while maintaining length.")]
	[ActionCategory(ActionCategory.Vector2)]
	public class Vector2SnapToAngle : FsmStateAction
	{
		private static bool showPreview;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector to snap to an angle.")]
		public FsmVector2 vector2Variable;

		[Tooltip("Angle increment to snap to.")]
		[PreviewField("DrawPreview")]
		public FsmFloat snapAngle;

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

		private void DoSnapToAngle()
		{
		}
	}
}
