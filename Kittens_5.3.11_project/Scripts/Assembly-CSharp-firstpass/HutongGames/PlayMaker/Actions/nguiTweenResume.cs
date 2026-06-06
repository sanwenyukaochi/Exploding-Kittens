namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Resume Tween that has been stop from previous state")]
	[ActionCategory("Ngui Actions")]
	public class nguiTweenResume : FsmStateAction
	{
		public FsmOwnerDefault NguiObject;

		private TweenRotation theTweenRot;

		private TweenPosition theTweenPos;

		private TweenColor theTweenColor;

		private TweenAlpha theTweenAlpha;

		private TweenScale theTweenScale;

		[ActionSection("Resume Tween")]
		public FsmBool resumeRotate;

		public FsmBool resumePosition;

		public FsmBool resumeColor;

		public FsmBool resumeAlpha;

		public FsmBool resumeScale;

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

		private void doResumeTween()
		{
		}
	}
}
