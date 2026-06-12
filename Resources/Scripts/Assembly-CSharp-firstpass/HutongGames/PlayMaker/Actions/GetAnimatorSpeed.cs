using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the playback speed of the Animator. 1 is normal playback speed")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorSpeed : FsmStateActionAnimatorBase
	{
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The playBack speed of the animator. 1 is normal playback speed")]
		public FsmFloat speed;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void GetPlaybackSpeed()
		{
		}
	}
}
