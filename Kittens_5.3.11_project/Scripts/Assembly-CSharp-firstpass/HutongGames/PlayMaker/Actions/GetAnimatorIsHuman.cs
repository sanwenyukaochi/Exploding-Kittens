using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns true if the current rig is humanoid, false if it is generic. Can also sends events")]
	public class GetAnimatorIsHuman : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("True if the current rig is humanoid, False if it is generic")]
		[UIHint(UIHint.Variable)]
		[ActionSection("Results")]
		public FsmBool isHuman;

		[Tooltip("Event send if rig is humanoid")]
		public FsmEvent isHumanEvent;

		[Tooltip("Event send if rig is generic")]
		public FsmEvent isGenericEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
