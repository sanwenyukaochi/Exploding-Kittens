using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("GUI base action - don't use!")]
	public abstract class GUIAction : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Screen rectangle.")]
		public FsmRect screenRect;

		[Tooltip("Left coordinate of screen rectangle.")]
		public FsmFloat left;

		[Tooltip("Top coordinate of screen rectangle.")]
		public FsmFloat top;

		[Tooltip("Width of screen rectangle.")]
		public FsmFloat width;

		[Tooltip("Height of screen rectangle.")]
		public FsmFloat height;

		[RequiredField]
		[Tooltip("Use normalized screen coordinates (0-1).")]
		public FsmBool normalized;

		internal Rect rect;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
