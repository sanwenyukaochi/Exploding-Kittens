using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the current transition information on a specified layer. Only valid when during a transition.")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorCurrentTransitionInfo : FsmStateActionAnimatorBase
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The unique name of the Transition")]
		public FsmString name;

		[UIHint(UIHint.Variable)]
		[Tooltip("The unique name of the Transition")]
		public FsmInt nameHash;

		[UIHint(UIHint.Variable)]
		[Tooltip("The user-specified name of the Transition")]
		public FsmInt userNameHash;

		[Tooltip("Normalized time of the Transition")]
		[UIHint(UIHint.Variable)]
		public FsmFloat normalizedTime;

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

		private void GetTransitionInfo()
		{
		}
	}
}
