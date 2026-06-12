namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Pick random Color and assign in Ngui Sprite. Make it up")]
	public class nguiChangeSpriteColorRandom : FsmStateAction
	{
		[Tooltip("NGUI Label to change Color")]
		[RequiredField]
		public FsmOwnerDefault NguiSpriteObject;

		private UISprite theNguiSprite;

		[Tooltip("Input your input Colors")]
		[CompoundArray("Colors", "Color", "Weight")]
		public FsmColor[] colors;

		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		[Tooltip("Change Color after an interval Time")]
		public FsmFloat intervalTime;

		[Tooltip("When true, runs only once")]
		public bool onceTime;

		private float currentTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void doChangeColorRandom()
		{
		}
	}
}
