namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Label for an Int Variable.")]
	public class GUILayoutIntLabel : GUILayoutAction
	{
		[Tooltip("Text to put before the int variable.")]
		public FsmString prefix;

		[Tooltip("Int variable to display.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		[Tooltip("Optional GUIStyle in the active GUISKin.")]
		public FsmString style;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
