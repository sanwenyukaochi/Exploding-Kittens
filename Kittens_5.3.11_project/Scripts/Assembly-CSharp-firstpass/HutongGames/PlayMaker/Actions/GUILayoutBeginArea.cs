using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begin a GUILayout block of GUI controls in a fixed screen area. NOTE: Block must end with a corresponding GUILayoutEndArea.")]
	public class GUILayoutBeginArea : FsmStateAction
	{
		[Tooltip("Screen area.")]
		[UIHint(UIHint.Variable)]
		public FsmRect screenRect;

		[Tooltip("Left screen coordinate.")]
		public FsmFloat left;

		[Tooltip("Top screen coordinate.")]
		public FsmFloat top;

		[Tooltip("Width of area.")]
		public FsmFloat width;

		[Tooltip("Height of area.")]
		public FsmFloat height;

		[Tooltip("Use normalized screen coordinates (0-1).")]
		public FsmBool normalized;

		[Tooltip("Optional GUIStyle name in current GUISkin.")]
		public FsmString style;

		private Rect rect;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
