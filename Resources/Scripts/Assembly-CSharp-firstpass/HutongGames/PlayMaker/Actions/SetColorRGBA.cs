namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the RGBA channels of a Color Variable. To leave any channel unchanged, set variable to 'None'.")]
	[ActionCategory(ActionCategory.Color)]
	public class SetColorRGBA : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Color Variable to set.")]
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the red channel of the color variable.")]
		public FsmFloat red;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the green channel of the color variable.")]
		public FsmFloat green;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the blue channel of the color variable.")]
		public FsmFloat blue;

		[Tooltip("Set the alpha channel of the color variable.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat alpha;

		[Tooltip("Repeat every frame.")]
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

		private void DoSetColorRGBA()
		{
		}
	}
}
