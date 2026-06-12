namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set inputed Text in current Ngui UIInput")]
	[ActionCategory("Ngui Actions")]
	public class nguiSetInputText : FsmStateAction
	{
		[Tooltip("NGUI UIInput to Set Text")]
		[RequiredField]
		public FsmOwnerDefault NguiUIinputObject;

		private UIInput theNguiUIinput;

		[Tooltip("Store current inputed text")]
		[UIHint(UIHint.FsmString)]
		public FsmString setText;

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

		private void doSetText()
		{
		}
	}
}
