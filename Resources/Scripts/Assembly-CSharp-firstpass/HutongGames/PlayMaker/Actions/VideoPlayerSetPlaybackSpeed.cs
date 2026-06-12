using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Set the factor by which the basic playback rate will be multiplied.")]
	public class VideoPlayerSetPlaybackSpeed : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The factor by which the basic playback rate will be multiplied.")]
		[RequiredField]
		public FsmFloat playbackSpeed;

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
