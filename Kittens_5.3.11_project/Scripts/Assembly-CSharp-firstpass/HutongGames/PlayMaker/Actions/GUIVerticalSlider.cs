namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI Vertical Slider connected to a Float Variable.")]
	public class GUIVerticalSlider : GUIAction
	{
		[Tooltip("The Float Variable linked to the slider value.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat floatVariable;

		[RequiredField]
		[Tooltip("The value of the variable at the top of the slider.")]
		public FsmFloat topValue;

		[Tooltip("The value of the variable at the bottom of the slider.")]
		[RequiredField]
		public FsmFloat bottomValue;

		[Tooltip("Optional GUIStyle for the slider track.")]
		public FsmString sliderStyle;

		[Tooltip("Optional GUIStyle for the slider thumb.")]
		public FsmString thumbStyle;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
