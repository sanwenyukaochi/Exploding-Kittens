namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutConfirmPasswordField : GUILayoutAction
	{
		[Tooltip("The password Text")]
		[UIHint(UIHint.Variable)]
		public FsmString text;

		[Tooltip("The Maximum Length of the field")]
		public FsmInt maxLength;

		[Tooltip("The Style of the Field")]
		public FsmString style;

		[Tooltip("Event sent when field content changed")]
		public FsmEvent changedEvent;

		[Tooltip("Replacement character to hide the password")]
		public FsmString mask;

		[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
		public FsmBool confirm;

		[Tooltip("Confirmation content")]
		public FsmString password;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
