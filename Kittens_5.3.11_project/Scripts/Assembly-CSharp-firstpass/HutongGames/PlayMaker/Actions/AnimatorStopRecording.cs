using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Stops the animator record mode. It will lock the recording buffer's contents in its current state. The data get saved for subsequent playback with StartPlayback.")]
	public class AnimatorStopRecording : ComponentAction<Animator>
	{
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required")]
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The recorder StartTime")]
		public FsmFloat recorderStartTime;

		[Tooltip("The recorder StopTime")]
		[UIHint(UIHint.Variable)]
		public FsmFloat recorderStopTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
