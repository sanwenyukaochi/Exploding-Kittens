using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set Apply Root Motion: If true, Root is controlled by animations")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorApplyRootMotion : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("If true, Root motion is controlled by animations")]
		public FsmBool applyRootMotion;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
