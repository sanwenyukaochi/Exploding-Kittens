using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Stops all playing Animations on a Game Object. Optionally, specify a single Animation to Stop.")]
	public class StopAnimation : BaseAnimationAction
	{
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The Game Object playing the animation.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the animation to stop. Leave empty to stop all playing animations.")]
		[UIHint(UIHint.Animation)]
		public FsmString animName;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoStopAnimation()
		{
		}
	}
}
