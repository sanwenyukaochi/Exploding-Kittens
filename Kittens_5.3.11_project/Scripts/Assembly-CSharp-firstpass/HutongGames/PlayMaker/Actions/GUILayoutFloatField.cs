namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Text Field to edit a Float Variable. Optionally send an event if the text has been edited.")]
	public class GUILayoutFloatField : GUILayoutAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Float Variable to show in the edit field.")]
		public FsmFloat floatVariable;

		[Tooltip("Optional GUIStyle in the active GUISKin.")]
		public FsmString style;

		[Tooltip("Optional event to send when the value changes.")]
		public FsmEvent changedEvent;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
