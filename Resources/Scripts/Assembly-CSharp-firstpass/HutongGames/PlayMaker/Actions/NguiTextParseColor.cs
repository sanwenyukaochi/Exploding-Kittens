namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("NGUI Tools")]
	[Tooltip("Parse a color string into color variable")]
	public class NguiTextParseColor : FsmStateAction
	{
		[Tooltip("The string representation of that color")]
		[RequiredField]
		public FsmString colorString;

		[Tooltip("The Color result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor color;

		private string _lastColor;

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
