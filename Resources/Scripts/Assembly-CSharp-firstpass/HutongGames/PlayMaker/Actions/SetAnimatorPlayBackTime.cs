using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the playback position in the recording buffer. When in playback mode (use AnimatorStartPlayback), this value is used for controlling the current playback position in the buffer (in seconds). The value can range between recordingStartTime and recordingStopTime ")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorPlayBackTime : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The playback time")]
		public FsmFloat playbackTime;

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

		private void DoPlaybackTime()
		{
		}
	}
}
