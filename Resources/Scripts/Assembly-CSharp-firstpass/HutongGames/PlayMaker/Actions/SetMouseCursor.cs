namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Controls the appearance of Mouse Cursor.")]
	[ActionCategory(ActionCategory.GUI)]
	public class SetMouseCursor : FsmStateAction
	{
		[Tooltip("The texture to use for the cursor.")]
		public FsmTexture cursorTexture;

		[Tooltip("Hide the cursor.")]
		public FsmBool hideCursor;

		[Tooltip("Lock the cursor to the center of the screen. Useful in first person controllers.")]
		public FsmBool lockCursor;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void UpdateCursorState()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
