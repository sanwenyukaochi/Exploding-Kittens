namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("TweenPosition Ngui Object")]
	public class nguiTweenPosition : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenPosition theTween;

		public FsmVector3 fromPosition;

		public FsmVector3 toPosition;

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

		public override void OnUpdate()
		{
		}
	}
}
