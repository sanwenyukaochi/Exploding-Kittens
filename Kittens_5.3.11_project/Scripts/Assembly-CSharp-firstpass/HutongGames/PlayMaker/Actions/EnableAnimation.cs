using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Enables/Disables an Animation on a GameObject.\nAnimation time is paused while disabled. Animation must also have a non zero weight to play.")]
	[ActionCategory(ActionCategory.Animation)]
	public class EnableAnimation : BaseAnimationAction
	{
		[Tooltip("The GameObject playing the animation.")]
		[CheckForComponent(typeof(Animation))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the animation to enable/disable.")]
		[RequiredField]
		[UIHint(UIHint.Animation)]
		public FsmString animName;

		[Tooltip("Set to True to enable, False to disable.")]
		[RequiredField]
		public FsmBool enable;

		[Tooltip("Reset the initial enabled state when exiting the state.")]
		public FsmBool resetOnExit;

		private AnimationState anim;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoEnableAnimation(GameObject go)
		{
		}

		public override void OnExit()
		{
		}
	}
}
