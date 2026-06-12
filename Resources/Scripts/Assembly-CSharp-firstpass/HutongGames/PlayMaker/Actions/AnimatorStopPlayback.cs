using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Stops the animator playback mode. When playback stops, the avatar resumes getting control from game logic")]
	[ActionCategory(ActionCategory.Animator)]
	public class AnimatorStopPlayback : ComponentAction<Animator>
	{
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
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
