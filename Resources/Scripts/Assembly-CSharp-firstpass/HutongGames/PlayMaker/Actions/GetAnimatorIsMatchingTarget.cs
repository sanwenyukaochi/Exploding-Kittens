using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns true if automatic matching is active. Can also send events")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorIsMatchingTarget : FsmStateActionAnimatorBase
	{
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if automatic matching is active")]
		public FsmBool isMatchingActive;

		[Tooltip("Event send if automatic matching is active")]
		public FsmEvent matchingActivatedEvent;

		[Tooltip("Event send if automatic matching is not active")]
		public FsmEvent matchingDeactivedEvent;

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

		private void DoCheckIsMatchingActive()
		{
		}
	}
}
