namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("NGUI Object has Depth Value (UIlabel/UISprite/UIButton/UIInput/UIPanel/UIScrollView) can be changed. Useful for group, reduce drawcall")]
	[ActionCategory("Ngui Actions")]
	public class nguiChangeDepth : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI Object has Depth Value can be changed")]
		public FsmOwnerDefault NguiObject;

		private UILabel isLabel;

		private UISprite isSprite;

		private UIButton isButton;

		private UIInput isInput;

		private UIPanel isUIPanel;

		[Tooltip("Input your input Depth Number")]
		public FsmInt depthValue;

		[Tooltip("Change Depth for all children")]
		public FsmBool applyToAllChildren;

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

		private void doChangeDepth()
		{
		}

		private void doApplyToChildren()
		{
		}
	}
}
