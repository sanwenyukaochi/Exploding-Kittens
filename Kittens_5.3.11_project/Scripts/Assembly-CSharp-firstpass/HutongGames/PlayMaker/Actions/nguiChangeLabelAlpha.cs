namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Change Alpha in Ngui Label. This will override Alpha Color")]
	public class nguiChangeLabelAlpha : FsmStateAction
	{
		[Tooltip("NGUI Label to change Alpha")]
		[RequiredField]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[Tooltip("Input your input Alpha")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat AlphaValue;

		[Tooltip("When true, runs on every frame")]
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

		private void doChangeAlPha()
		{
		}
	}
}
