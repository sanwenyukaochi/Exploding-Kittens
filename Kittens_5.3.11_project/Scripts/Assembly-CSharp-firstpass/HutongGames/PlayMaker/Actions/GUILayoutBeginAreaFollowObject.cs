namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begin a GUILayout area that follows the specified game object. Useful for overlays (e.g., playerName). NOTE: Block must end with a corresponding GUILayoutEndArea.")]
	public class GUILayoutBeginAreaFollowObject : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to follow.")]
		public FsmGameObject gameObject;

		[Tooltip("Left screen offset.")]
		[RequiredField]
		public FsmFloat offsetLeft;

		[RequiredField]
		[Tooltip("Screen offset up.")]
		public FsmFloat offsetTop;

		[RequiredField]
		[Tooltip("Width of area.")]
		public FsmFloat width;

		[RequiredField]
		[Tooltip("Height of area.")]
		public FsmFloat height;

		[Tooltip("Use normalized screen coordinates (0-1).")]
		public FsmBool normalized;

		[Tooltip("Optional named style in the current GUISkin")]
		public FsmString style;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}

		private static void DummyBeginArea()
		{
		}
	}
}
