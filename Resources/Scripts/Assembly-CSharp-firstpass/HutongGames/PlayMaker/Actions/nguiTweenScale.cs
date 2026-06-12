namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("TweenScale Ngui Object")]
	[ActionCategory("Ngui Actions")]
	public class nguiTweenScale : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenScale theTween;

		public FsmVector3 fromScale;

		public FsmVector3 toScale;

		public UITweener.Style playStyle;

		public UITweener.Method method;

		public FsmFloat duration;

		public FsmFloat delay;

		public FsmInt group;

		public FsmBool ignoreTimeScale;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
