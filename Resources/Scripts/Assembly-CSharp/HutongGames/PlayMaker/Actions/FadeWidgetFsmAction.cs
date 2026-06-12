namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Changes an NGUI Widget's alpha over time.")]
	[ActionCategory("iTween")]
	public class FadeWidgetFsmAction : iTweenFsmAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		[Tooltip("Start alpha (0..1)")]
		public FsmFloat fromAlpha;

		[Tooltip("End alpha (0..1)")]
		public FsmFloat toAlpha;

		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		private UIWidget widget;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void DoiTween()
		{
		}

		private void TweenAlpha(float alpha)
		{
		}
	}
}
