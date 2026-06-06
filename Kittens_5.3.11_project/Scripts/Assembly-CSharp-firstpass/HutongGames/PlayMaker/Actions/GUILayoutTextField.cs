namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("GUILayout Text Field. Optionally send an event if the text has been edited.")]
	[ActionCategory(ActionCategory.GUILayout)]
	public class GUILayoutTextField : GUILayoutAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Link the text field to a String Variable.")]
		public FsmString text;

		[Tooltip("The max number of characters that can be entered.")]
		public FsmInt maxLength;

		[Tooltip("Optional named style in the current GUISkin")]
		public FsmString style;

		[Tooltip("An optional Event to send when the text field value changes.")]
		public FsmEvent changedEvent;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
