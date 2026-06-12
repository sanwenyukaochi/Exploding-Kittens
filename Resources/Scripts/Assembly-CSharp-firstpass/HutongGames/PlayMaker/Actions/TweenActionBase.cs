using System;
using HutongGames.PlayMaker.TweenEnums;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	public abstract class TweenActionBase : BaseUpdateAction
	{
		[Tooltip("Delay before starting the tween.")]
		[ActionSection("Easing")]
		public FsmFloat startDelay;

		[Tooltip("The type of easing to apply.")]
		[ObjectType(typeof(EasingFunction.Ease))]
		[PreviewField("DrawPreview")]
		public FsmEnum easeType;

		[Tooltip("Custom tween curve. Note: Typically you would use the 0-1 range.")]
		[HideIf("HideCustomCurve")]
		public FsmAnimationCurve customCurve;

		[Tooltip("Length of tween in seconds.")]
		public FsmFloat time;

		[Tooltip("Ignore any time scaling.")]
		public FsmBool realTime;

		[Tooltip("Looping options.")]
		public LoopType loopType;

		[Tooltip("Event to send when tween is finished.")]
		public FsmEvent finishEvent;

		[NonSerialized]
		public float normalizedTime;

		protected bool tweenStarted;

		protected bool tweenFinished;

		protected float currentTime;

		protected bool playPreview;

		private EasingFunction.Ease cachedEase;

		private EasingFunction.Function func;

		private static bool showPreviewCurve;

		private bool reverse;

		public EasingFunction.Function easingFunction => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		protected abstract void DoTween();
	}
}
