using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Plays a state. This could be used to synchronize your animation with audio or synchronize an Animator over the network.")]
	[ActionCategory(ActionCategory.Animator)]
	public class AnimatorPlay : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the state that will be played.")]
		public FsmString stateName;

		[Tooltip("The layer where the state is.")]
		public FsmInt layer;

		[Tooltip("The normalized time at which the state will play")]
		public FsmFloat normalizedTime;

		[Tooltip("Repeat every frame. Useful when using normalizedTime to manually control the animation.")]
		public bool everyFrame;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoAnimatorPlay()
		{
		}
	}
}
