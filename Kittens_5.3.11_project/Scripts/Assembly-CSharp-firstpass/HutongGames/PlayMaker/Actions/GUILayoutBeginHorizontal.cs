namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout BeginHorizontal.")]
	public class GUILayoutBeginHorizontal : GUILayoutAction
	{
		[Tooltip("Texture to display.")]
		public FsmTexture image;

		[Tooltip("Text to display.")]
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
