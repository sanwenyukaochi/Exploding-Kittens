namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Get current inputed Text in Ngui UIInput")]
	public class nguiGetInputText : FsmStateAction
	{
		[Tooltip("NGUI UIInput to Get Text")]
		[RequiredField]
		public FsmOwnerDefault NguiUIinputObject;

		private UIInput theNguiUIinput;

		[Tooltip("Store current inputed text")]
		[UIHint(UIHint.Variable)]
		public FsmString storeText;

		public FsmEvent Empty;

		public FsmEvent notEmpty;

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

		private void doGetText()
		{
		}
	}
}
