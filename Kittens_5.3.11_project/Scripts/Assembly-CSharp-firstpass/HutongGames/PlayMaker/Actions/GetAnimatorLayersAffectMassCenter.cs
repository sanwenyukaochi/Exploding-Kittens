using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns if additional layers affects the mass center")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorLayersAffectMassCenter : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("If true, additional layers affects the mass center")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[ActionSection("Results")]
		public FsmBool affectMassCenter;

		[Tooltip("Event send if additional layers affects the mass center")]
		public FsmEvent affectMassCenterEvent;

		[Tooltip("Event send if additional layers do no affects the mass center")]
		public FsmEvent doNotAffectMassCenterEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
