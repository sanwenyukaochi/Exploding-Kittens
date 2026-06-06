using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Interrupts the automatic target matching. CompleteMatch will make the GameObject match the target completely at the next frame.")]
	public class AnimatorInterruptMatchTarget : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Will make the GameObject match the target completely at the next frame")]
		public FsmBool completeMatch;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
