namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Stop Tween that are currently active")]
	[ActionCategory("Ngui Actions")]
	public class nguiTweenStop : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenRotation theTweenRot;

		private TweenPosition theTweenPos;

		private TweenColor theTweenColor;

		private TweenAlpha theTweenAlpha;

		private TweenScale theTweenScale;

		[ActionSection("Stop Tween")]
		public FsmBool stopRotate;

		public FsmBool stopPosition;

		public FsmBool stopColor;

		public FsmBool stopAlpha;

		public FsmBool stopScale;

		[ActionSection("Do Everyframe")]
		public FsmBool everyframe;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void doStopTween()
		{
		}
	}
}
