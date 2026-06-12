namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Change Alpha in Ngui Sprite. This will override Alpha Color and Affect on all of its Children")]
	public class nguiChangeSpriteAlpha : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Sprite to change Alpha")]
		public FsmOwnerDefault NguiSpriteObject;

		private UIWidget theNguiSprite;

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
