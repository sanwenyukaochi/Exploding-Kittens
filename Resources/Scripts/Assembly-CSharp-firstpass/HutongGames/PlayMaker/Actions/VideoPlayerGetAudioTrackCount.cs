using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Number of audio tracks found in the data source currently configured on a videoPlayer. For URL sources, this will only be set once the source preparation is completed. See VideoPlayer.Prepare.")]
	public class VideoPlayerGetAudioTrackCount : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Number of audio tracks found in the data source currently configured")]
		[UIHint(UIHint.Variable)]
		public FsmInt audioTrackCount;

		[Tooltip("Event sent if source is not prepared")]
		public FsmEvent isNotPrepared;

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
