namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("TweenPosition Ngui Object from two points of gameobjects in scene")]
	public class nguiTweenPositionAsGameobjects : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenPosition theTween;

		private FsmVector3 fromPosition;

		private FsmVector3 toPosition;

		public FsmGameObject fromWhere;

		public FsmGameObject toWhere;

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
