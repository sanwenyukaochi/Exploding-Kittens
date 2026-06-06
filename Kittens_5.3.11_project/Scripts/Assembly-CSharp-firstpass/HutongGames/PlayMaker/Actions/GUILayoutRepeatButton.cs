namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Repeat Button. Sends an Event while pressed. Optionally store the button state in a Bool Variable.")]
	public class GUILayoutRepeatButton : GUILayoutAction
	{
		[Tooltip("The fsm event to send while the button is pressed.")]
		public FsmEvent sendEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the button state in a Bool Variable.")]
		public FsmBool storeButtonState;

		[Tooltip("The texture to display.")]
		public FsmTexture image;

		[Tooltip("The text to display.")]
		public FsmString text;

		[Tooltip("Optional tooltip. Accessed by {{GUI Tooltip}}")]
		public FsmString tooltip;

		[Tooltip("Optional named style in the current GUISkin")]
		public FsmString style;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
