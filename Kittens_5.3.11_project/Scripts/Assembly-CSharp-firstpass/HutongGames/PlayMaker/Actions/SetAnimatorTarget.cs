using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets an AvatarTarget and a targetNormalizedTime for the current state")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorTarget : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with the Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The avatar target")]
		public AvatarTarget avatarTarget;

		[Tooltip("The current state Time that is queried")]
		public FsmFloat targetNormalizedTime;

		[Tooltip("Repeat every frame during OnAnimatorMove. Useful when changing over time.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void DoAnimatorMove()
		{
		}

		private void SetTarget()
		{
		}
	}
}
