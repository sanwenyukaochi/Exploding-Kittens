using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Sets the current Time of an Animation. Useful for manually controlling playback of an animation. Check Every Frame to update the time continuously.")]
	public class SetAnimationTime : BaseAnimationAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The Game Object playing the animation.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the animation.")]
		[UIHint(UIHint.Animation)]
		[RequiredField]
		public FsmString animName;

		[Tooltip("The time to set the animation to.")]
		public FsmFloat time;

		[Tooltip("Use normalized time: 0 = start ; 1 = end. Useful if you don't care about the length of the exact length of the animation.")]
		public bool normalized;

		[Tooltip("Set time every frame. Useful if you're using a variable as Time.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetAnimationTime(GameObject go)
		{
		}
	}
}
