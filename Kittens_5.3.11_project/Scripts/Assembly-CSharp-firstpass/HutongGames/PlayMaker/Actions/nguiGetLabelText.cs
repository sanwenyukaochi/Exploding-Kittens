namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Get current Text in Ngui Label")]
	public class nguiGetLabelText : FsmStateAction
	{
		[Tooltip("NGUI Label to Get Text")]
		[RequiredField]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store current text")]
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
