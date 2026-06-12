using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns The current gravity weight based on current animations that are played")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorGravityWeight : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The current gravity weight based on current animations that are played")]
		[ActionSection("Results")]
		public FsmFloat gravityWeight;

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

		private void DoGetGravityWeight()
		{
		}
	}
}
