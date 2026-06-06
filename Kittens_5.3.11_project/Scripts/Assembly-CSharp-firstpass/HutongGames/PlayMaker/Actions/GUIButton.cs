namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI button. Sends an Event when pressed. Optionally store the button state in a Bool Variable.")]
	public class GUIButton : GUIContentAction
	{
		[Tooltip("The Event to send when the button is pressed.")]
		public FsmEvent sendEvent;

		[Tooltip("Store the button state in a bool variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeButtonState;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
