namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Makes an on/off Toggle Button and stores the button state in a Bool Variable.")]
	[ActionCategory(ActionCategory.GUILayout)]
	public class GUILayoutToggle : GUILayoutAction
	{
		[Tooltip("Link the button state to this Bool Variable.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmBool storeButtonState;

		[Tooltip("Texture to display.")]
		public FsmTexture image;

		[Tooltip("Text to display.")]
		public FsmString text;

		[Tooltip("Optional tooltip. Accessed by {{GUI Tooltip}}")]
		public FsmString tooltip;

		[Tooltip("Optional named style in the current GUISkin")]
		public FsmString style;

		[Tooltip("Optional Event to send when the toggle changes.")]
		public FsmEvent changedEvent;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
