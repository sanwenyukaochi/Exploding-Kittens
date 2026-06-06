using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check the active Transition name on a specified layer. Format is 'CURRENT_STATE -> NEXT_STATE'.")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorCurrentTransitionInfoIsName : FsmStateActionAnimatorBase
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		[Tooltip("The name to check the transition against.")]
		public FsmString name;

		[Tooltip("True if name matches")]
		[UIHint(UIHint.Variable)]
		[ActionSection("Results")]
		public FsmBool nameMatch;

		[Tooltip("Event send if name matches")]
		public FsmEvent nameMatchEvent;

		[Tooltip("Event send if name doesn't match")]
		public FsmEvent nameDoNotMatchEvent;

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

		private void IsName()
		{
		}
	}
}
