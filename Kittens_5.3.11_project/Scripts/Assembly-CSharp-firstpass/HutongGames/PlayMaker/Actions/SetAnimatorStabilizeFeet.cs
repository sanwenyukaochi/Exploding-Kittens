using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("If true, automatically stabilize feet during transition and blending")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorStabilizeFeet : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("If true, automatically stabilize feet during transition and blending")]
		public FsmBool stabilizeFeet;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
