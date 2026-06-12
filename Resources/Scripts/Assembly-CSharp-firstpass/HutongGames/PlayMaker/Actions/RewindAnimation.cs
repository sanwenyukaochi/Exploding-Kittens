using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Rewinds the named animation.")]
	[ActionCategory(ActionCategory.Animation)]
	public class RewindAnimation : BaseAnimationAction
	{
		[Tooltip("The Game Object playing the animation.")]
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation to rewind.")]
		public FsmString animName;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoRewindAnimation()
		{
		}
	}
}
