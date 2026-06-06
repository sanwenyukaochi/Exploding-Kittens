namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("TweenRotation Ngui Object")]
	public class nguiTweenRotation : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenRotation theTween;

		public FsmVector3 fromPosition;

		public FsmVector3 toPosition;

		public UITweener.Style playStyle;

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
