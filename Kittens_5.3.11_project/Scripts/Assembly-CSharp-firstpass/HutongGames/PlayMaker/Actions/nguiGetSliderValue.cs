namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Get Value in Progress Bar or Slider in current Ngui UISlider")]
	public class nguiGetSliderValue : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI UISlider to Get value")]
		public FsmOwnerDefault NguiUISliderObject;

		private UISlider theNguiUISlider;

		[Tooltip("Store current value")]
		[UIHint(UIHint.FsmFloat)]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat getValue;

		[UIHint(UIHint.Variable)]
		public FsmString valueAsString;

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
