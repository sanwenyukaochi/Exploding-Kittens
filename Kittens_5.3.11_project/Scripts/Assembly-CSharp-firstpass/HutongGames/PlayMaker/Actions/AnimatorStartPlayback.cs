using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the animator in playback mode.")]
	[ActionCategory(ActionCategory.Animator)]
	public class AnimatorStartPlayback : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
