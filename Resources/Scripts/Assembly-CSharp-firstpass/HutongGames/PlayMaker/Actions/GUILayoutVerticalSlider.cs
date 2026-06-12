namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("A Vertical Slider linked to a Float Variable.")]
	public class GUILayoutVerticalSlider : GUILayoutAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float Variable linked to the slider value.")]
		public FsmFloat floatVariable;

		[Tooltip("The value of the variable at the top of the slider.")]
		[RequiredField]
		public FsmFloat topValue;

		[RequiredField]
		[Tooltip("The value of the variable at the bottom of the slider.")]
		public FsmFloat bottomValue;

		[Tooltip("Optional Event to send when the slider value changes.")]
		public FsmEvent changedEvent;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
