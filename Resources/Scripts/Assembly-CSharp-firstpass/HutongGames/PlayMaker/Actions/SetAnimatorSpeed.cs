using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the playback speed of the Animator. 1 is normal playback speed")]
	public class SetAnimatorSpeed : ComponentAction<Animator>
	{
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The playback speed.")]
		public FsmFloat speed;

		[Tooltip("Repeat every frame. Useful for changing over time.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoPlaybackSpeed()
		{
		}
	}
}
