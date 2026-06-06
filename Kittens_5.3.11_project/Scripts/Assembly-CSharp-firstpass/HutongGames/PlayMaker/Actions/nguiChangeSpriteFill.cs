namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Change Fill Amount of a Ngui Sprite.")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeSpriteFill : FsmStateAction
	{
		[Tooltip("NGUI Sprite to change Alpha")]
		[RequiredField]
		public FsmOwnerDefault NguiSpriteObject;

		private UISprite theNguiSprite;

		public UIBasicSprite.FillDirection fillDir;

		public UIBasicSprite.Flip flip;

		[Tooltip("Input your input Fill Amount")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat FillValue;

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
