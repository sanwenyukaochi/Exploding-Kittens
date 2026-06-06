using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Get the factor by which the basic playback rate will be multiplied.")]
	public class VideoPlayerGetPlaybackSpeed : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The factor by which the basic playback rate will be multiplied.")]
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
