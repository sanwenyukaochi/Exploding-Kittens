namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("TweenColor Ngui Object")]
	public class nguiTweenColor : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenColor theTween;

		public FsmColor fromColor;

		public FsmColor toColor;

		public UITweener.Style playStyle;

		public UITweener.Method method;

		public FsmFloat duration;

		public FsmFloat delay;

		public FsmInt group;

		public FsmBool ignoreTimeScale;

		[Tooltip("When true, runs on every frame")]
		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
