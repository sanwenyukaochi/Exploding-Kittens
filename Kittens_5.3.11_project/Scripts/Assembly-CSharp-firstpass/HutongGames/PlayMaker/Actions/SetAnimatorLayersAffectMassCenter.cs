using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("If true, additional layers affects the mass center")]
	public class SetAnimatorLayersAffectMassCenter : ComponentAction<Animator>
	{
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("If true, additional layers affects the mass center")]
		public FsmBool affectMassCenter;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
