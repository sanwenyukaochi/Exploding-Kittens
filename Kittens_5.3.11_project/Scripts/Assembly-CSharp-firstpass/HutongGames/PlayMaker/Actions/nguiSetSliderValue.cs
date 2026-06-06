namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Set Value in Progress Bar or Slider in current Ngui UISlider")]
	public class nguiSetSliderValue : FsmStateAction
	{
		[RequiredField]
		[Tooltip("NGUI UISlider to Set value")]
		public FsmOwnerDefault NguiUISliderObject;

		private UISlider theNguiUISlider;

		[Tooltip("Set this value to Slider/Progress bar")]
		[UIHint(UIHint.FsmFloat)]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat setValue;

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

		private void doSetvalue()
		{
		}
	}
}
