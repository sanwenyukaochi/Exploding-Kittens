namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("TweenAlpha NGUI object")]
	public class nguiTweenAlpha : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenAlpha theTween;

		public FsmFloat fromAlpha;

		public FsmFloat toAlpha;

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
