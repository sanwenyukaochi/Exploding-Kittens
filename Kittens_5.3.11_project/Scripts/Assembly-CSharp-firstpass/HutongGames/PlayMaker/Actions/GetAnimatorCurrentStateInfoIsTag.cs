using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Does tag match the tag of the active state in the state machine")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorCurrentStateInfoIsTag : FsmStateActionAnimatorBase
	{
		[RequiredField]
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		[Tooltip("The tag to check the layer against.")]
		public FsmString tag;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if tag matches")]
		public FsmBool tagMatch;

		[Tooltip("Event send if tag matches")]
		public FsmEvent tagMatchEvent;

		[Tooltip("Event send if tag matches")]
		public FsmEvent tagDoNotMatchEvent;

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

		private void IsTag()
		{
		}
	}
}
