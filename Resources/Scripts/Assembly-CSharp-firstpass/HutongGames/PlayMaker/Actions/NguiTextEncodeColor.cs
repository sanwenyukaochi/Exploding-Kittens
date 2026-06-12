using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("NGUI Tools")]
	[Tooltip("Encode a color into a string for label coloring tags")]
	public class NguiTextEncodeColor : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Color")]
		public FsmColor color;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The string representation  result of that color")]
		public FsmString colorString;

		private Color _lastColor;

		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
