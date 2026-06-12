namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("A Horizontal Slider linked to a Float Variable.")]
	public class GUILayoutHorizontalSlider : GUILayoutAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to link the slider to. Moving the slider changes the value, and changes in the value move the slider.")]
		public FsmFloat floatVariable;

		[RequiredField]
		[Tooltip("The value of the float variable when slider is all the way to the left.")]
		public FsmFloat leftValue;

		[RequiredField]
		[Tooltip("The value of the float variable when slider is all the way to the right.")]
		public FsmFloat rightValue;

		[Tooltip("An optional fsm event to send when the value changes.")]
		public FsmEvent changedEvent;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
