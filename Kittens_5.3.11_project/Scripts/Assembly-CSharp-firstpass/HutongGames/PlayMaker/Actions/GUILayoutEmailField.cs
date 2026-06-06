namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
	[ActionCategory(ActionCategory.GUILayout)]
	public class GUILayoutEmailField : GUILayoutAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The email Text")]
		public FsmString text;

		[Tooltip("The Maximum Length of the field")]
		public FsmInt maxLength;

		[Tooltip("The Style of the Field")]
		public FsmString style;

		[Tooltip("Event sent when field content changed")]
		public FsmEvent changedEvent;

		[Tooltip("Email valid format flag")]
		public FsmBool valid;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
