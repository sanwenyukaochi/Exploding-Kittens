using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Check Whether the playback speed can be changed on a VideoPlayer. (Read Only)")]
	public class VideoPlayerGetCanSetPlaybackSpeed : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Value")]
		[UIHint(UIHint.Variable)]
		public FsmBool canSetPlaybackSpeed;

		[Tooltip("Event sent if PlaybackSpeed can be set")]
		public FsmEvent canSetTimePlaybackSpeed;

		[Tooltip("Event sent if PlaybackSpeed can not be set")]
		public FsmEvent canNotSetTimePlaybackSpeed;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject go;

		private VideoPlayer _vp;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void ExecuteAction()
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
