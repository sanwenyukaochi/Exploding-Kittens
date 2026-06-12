using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the value of ApplyRootMotion of an avatar. If true, root is controlled by animations")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorApplyRootMotion : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[ActionSection("Results")]
		[RequiredField]
		[Tooltip("Is the rootMotionapplied. If true, root is controlled by animations")]
		public FsmBool rootMotionApplied;

		[Tooltip("Event send if the root motion is applied")]
		public FsmEvent rootMotionIsAppliedEvent;

		[Tooltip("Event send if the root motion is not applied")]
		public FsmEvent rootMotionIsNotAppliedEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
