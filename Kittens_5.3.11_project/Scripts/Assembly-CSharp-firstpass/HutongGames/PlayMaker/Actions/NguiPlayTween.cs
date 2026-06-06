using AnimationOrTween;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Play a NGUI Tween. It is the same as the NGUI component 'Button Tween', only without the need for a NGUI button")]
	[ActionCategory("NGUI")]
	public class NguiPlayTween : FsmStateAction
	{
		[Tooltip("The GameObject on which there is one or more NGUI tween.")]
		[RequiredField]
		[CheckForComponent(typeof(UITweener))]
		public FsmOwnerDefault tweenTarget;

		[Tooltip("If there are multiple tweens, you can choose which ones get activated by changing their group. Default is 0")]
		public FsmInt tweenGroup;

		[Tooltip("Direction to tween in.")]
		public Direction playDirection;

		[Tooltip("Whether the tween will be reset to the start or end when activated. If not, it will continue from where it currently is.")]
		public FsmBool resetOnPlay;

		[Tooltip("Whether the tween will be reset to the start if it's disabled when activated.")]
		public FsmBool resetIfDisabled;

		[Tooltip("What to do if the tweenTarget game object is currently disabled.")]
		public EnableCondition ifDisabledOnPlay;

		[Tooltip("What to do with the tweenTarget after the tween finishes.")]
		public DisableCondition disableWhenFinished;

		[Tooltip("Whether the tweens on the child game objects will be considered.")]
		public FsmBool includeChildren;

		[Tooltip("Event to trigger when the tween finishes.")]
		public FsmEvent tweeningFinishedEvent;

		private UITweener[] mTweens;

		private GameObject _tweenTarget;

		private int mActive;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public void PlayTweeners()
		{
		}

		private void OnFinished()
		{
		}
	}
}
