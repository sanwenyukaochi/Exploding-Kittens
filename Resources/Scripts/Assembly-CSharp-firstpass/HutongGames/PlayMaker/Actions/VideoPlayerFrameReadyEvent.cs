using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Send the frameReady event from a VideoPlayer when a new frame is ready.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerFrameReadyEvent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("event sent when a new frame is ready.")]
		public FsmEvent onFrameReadyEvent;

		private GameObject go;

		private VideoPlayer _vp;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void OnFrameReady(VideoPlayer source, long frameIndex)
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
