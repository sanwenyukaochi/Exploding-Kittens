namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Box.")]
	public class GUILayoutBox : GUILayoutAction
	{
		[Tooltip("Image to display in the Box.")]
		public FsmTexture image;

		[Tooltip("Text to display in the Box.")]
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
