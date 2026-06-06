namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("replace/change Ngui Sprite. The new sprite must exist in current Atlas")]
	[ActionCategory("Ngui Actions")]
	public class nguiReplaceSprite : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Sprite to change")]
		public FsmOwnerDefault NguiSpriteObject;

		private UISprite theNguiSprite;

		[Tooltip("New Sprite name")]
		public FsmString newSpriteName;

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

		private void doChangeSprite()
		{
		}
	}
}
