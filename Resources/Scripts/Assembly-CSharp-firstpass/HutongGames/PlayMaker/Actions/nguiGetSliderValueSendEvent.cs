namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Get Value in Progress Bar or Slider with compare Event")]
	public class nguiGetSliderValueSendEvent : FsmStateAction
	{
		[Tooltip("NGUI UISlider to Set value")]
		[ActionSection("GET VALUE")]
		[RequiredField]
		public FsmOwnerDefault NguiUISliderObject;

		private UISlider theNguiUISlider;

		[UIHint(UIHint.FsmFloat)]
		[Tooltip("Store current value")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat getValue;

		[ActionSection("SEND EVENT")]
		public FsmFloat valueCondition;

		public FsmEvent greaterThan;

		public FsmEvent equal;

		public FsmEvent lessThan;

		private float tolerance;

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

		private void doGetvalue()
		{
		}
	}
}
