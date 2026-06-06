namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begins a vertical control group. The group must be closed with GUILayoutEndVertical action.")]
	public class GUILayoutBeginVertical : GUILayoutAction
	{
		[Tooltip("The texture to display.")]
		public FsmTexture image;

		[Tooltip("The text to display.")]
		public FsmString text;

		[Tooltip("The tooltip associated with this control. See {{GUI Tooltip}}")]
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
