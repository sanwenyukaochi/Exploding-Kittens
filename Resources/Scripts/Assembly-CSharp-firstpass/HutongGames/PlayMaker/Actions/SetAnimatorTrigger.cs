using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a trigger parameter to active. Triggers are parameters that act mostly like booleans, but get reset to inactive when they are used in a transition.")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorTrigger : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.AnimatorTrigger)]
		[RequiredField]
		[Tooltip("The trigger name")]
		public FsmString trigger;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
